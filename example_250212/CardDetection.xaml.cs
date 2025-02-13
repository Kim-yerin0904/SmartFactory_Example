using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Tesseract;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Drawing;
using System.IO;
using System.Net.Http;

namespace example_250212
{
    /// <summary>
    /// Interaction logic for CardDetection.xaml
    /// </summary>
    public partial class CardDetection : System.Windows.Window
    {
        public CardDetection()
        {
            InitializeComponent();

            string imgPath = "C:\\Users\\yeeli\\source\\repos\\example_241218\\example_250212\\image.png";
            Mat src = Cv2.ImRead(imgPath);

            OpenCvSharp.Point[] squares = Square(src);  // 사각형 검출
            Mat square = DrawSquare(src, squares);  // 사각형 그리기
            Mat dst = PerspectiveTransform(src, squares);   //원근 변환
            textBox.Text = OCR(dst);  // 문자열 검출

            Cv2.ImShow("square", square);
            Cv2.ImShow("dst", dst);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
        }

        #region 사각형 검출
        static double Angle(OpenCvSharp.Point pt1, OpenCvSharp.Point pt0, OpenCvSharp.Point pt2)
        {
            double u1 = pt1.X - pt0.X;
            double u2 = pt1.Y - pt0.Y;
            double v1 = pt2.X - pt0.X;
            double v2 = pt2.Y - pt0.Y;

            return ((u1 * v1 + u2 * v2) / (Math.Sqrt(u1 * u1 + u2 * u2) * Math.Sqrt(v1 * v1 + v2 * v2)));
        }

        public static OpenCvSharp.Point[] Square(Mat src)
        {
            Mat[] split = Cv2.Split(src);  // BGR 3채널 이미지를 각각 채녈 별로 Mat에 따로 저장
            Mat blur = new Mat();  // 블러가 적용된 이미지를 햘당할 예정
            Mat binary = new Mat();   // 이진화 이미지를 할당할 예정

            OpenCvSharp.Point[] squares = new OpenCvSharp.Point[4];  // 사각형의 꼭지점 좌표가 할당될 예정

            int N = 10;   // 각각 다른 옵션을 주어 검출할 이미지의 개수 

            // 이미지에서 검출된 사각형이 너무 크거나 작으면 사용하지 않기 위해 범위를 정해둠
            double max = src.Size().Width * src.Size().Height * 0.9;
            double min = src.Size().Width * src.Size().Height * 0.1;

            // BGR 각각에 대해 수행
            for (int channel = 0; channel < 3; channel++)
            {
                // 5x5 크기의 커널을 갖는 가우시아 블러를 적용하여 흐림효과를 주는 것으로 작은 노이즈들 제거
                Cv2.GaussianBlur(split[channel], blur, new OpenCvSharp.Size(5, 5), 1);
                for (int i = 0; i < N; i++)
                {
                    // 임계값 i*255/N 을 기준으로 작은 값은 0(검정), 큰 값은 255(흰)로 이진화
                    Cv2.Threshold(blur, binary, i * 255 / N, 255, ThresholdTypes.Binary);

                    // 윤곽점 및 계층이 할당될 예정
                    OpenCvSharp.Point[][] contours;
                    HierarchyIndex[] hierarchy;

                    // 윤곽선 검출
                    Cv2.FindContours(binary, out contours, out hierarchy, RetrievalModes.List, 
                        ContourApproximationModes.ApproxTC89KCOS);

                    // 컨투어 그리기 테스트용(?) 
                    Mat test = src.Clone();
                    Cv2.DrawContours(test, contours, -1, new Scalar(0, 0, 255), 3);

                    // 다각형 근사를 활용하여 사각형을 판별 
                    // 모든 윤곽선에 대해 수행하기 위한 for문 
                    for (int j = 0; j < contours.Length; j++)
                    {
                        // 다각형 근사에 필요한 Epsilon 값을 결정하기 위해 윤곽선들의 전체 길이를 구함
                        double perimeter = Cv2.ArcLength(contours[j], true);

                        // 윤곽선을 이용해 다각형 근사
                        // ArcLength()를 통해 구한 윤곽선의 전체 길이의 2%를 할당
                        // Epsilon 값이 작을수록 도형을 민감하게 검출하지만 사각형이 아닐 확률은 올라감
                        // 사각형은 닫힌 도형이므로 폐곡선의 값은 true
                        OpenCvSharp.Point[] result = Cv2.ApproxPolyDP(contours[j], perimeter * 0.02, true);

                        // 검출된 도형이 사각형이 맞는지 확인하기 위해 면적과 볼록한 정도를 계산
                        double area = Cv2.ContourArea(result);  // 면적 계산
                        bool convex = Cv2.IsContourConvex(result);  // 볼록한 정도(convex)를 계산

                        // result.Length == 4, 검출된 점이 4개인지 확인
                        // area > min, area < max, 원본 이미지 크기 대비 10% 이상, 90% 미만
                        // convex, 점끼리 연결한 선이 직선이면 true, 곡선이면 false
                        if (result.Length == 4 && area > min && area < max && convex)
                        {
                            // 위 조건을 모두 통과하더라도 마름모 또는 사다리꼴 형태일 수돌 있기 때문에
                            // 삼각함수로 각 선들 사이의 각도가 90도인지 확인
                            double cos = 0;  // cos 값이 0에 가까울수록 직각에 가까움

                            // 각도 계산을 각 꼭지점 별로 4회 수행
                            // K 값이 -1일때 0이 되서 첫번째 요소를 Angle에 전달할 수 있도록 K=1부터 시작
                            for (int k = 1; k < 5; k++)
                            {
                                // Angle: 점 3개를 입력하면 세 점이 이어졌을 때 각도를 cos으로 구해줌
                                // 90도를 살짝 넘어가면 음수가 나오기 때문에 Abs로 절대값을 적용
                                // 정확히 90인 것을 구하는 것은 아니고 90도에 근접한 것을 구하는 것이기 때문
                                double t = Math.Abs(Angle(result[(k - 1) % 4], result[k % 4], result[(k + 1) % 4]));
                                
                                // cos 보다 t가 작으면 cos = cos
                                // cos 보다 t가 크면 cos = t
                                // 결국 가장 큰 값이 cos에 들어가게 됨
                                cos = cos > t ? cos : t;
                            }

                            // 사각형의 각 꼭지점의 cos값 중 가장 큰 값이 0.15보다 작으면 
                            // 각도가 약 81도이고 직각에 가깝기 때문에 사각형이라고 인정
                            if (cos < 0.15)
                            {
                                squares = result;
                            }
                        }
                    }
                }
            }
            return (squares);
        }

        // 점 4개가 주어지면 사각형을 그려줌
        public static Mat DrawSquare(Mat src, OpenCvSharp.Point[] squares)
        {
            Mat drawsquare = src.Clone();

            OpenCvSharp.Point[][] pts = new OpenCvSharp.Point[][] { squares };
            Cv2.Polylines(drawsquare, pts, true, Scalar.Yellow, 3, LineTypes.AntiAlias, 0);
            return (drawsquare);
        }
        #endregion

        #region 원근 변환!
        // 기울어져있는 사각형을 원근 변환을 적용하여 직사각형으로 변형
        public static Mat PerspectiveTransform(Mat src, OpenCvSharp.Point[] squares)
        {
            Mat dst = new Mat();
            Moments moments = Cv2.Moments(squares);
            
            // 중심점 구하는 공식 = 1차 모멘트(M10, M01) / 0자 모멘트 (M00)
            double cX = moments.M10 / moments.M00;   // 중심점의 X 좌표
            double cY = moments.M01 / moments.M00;   // 중심점의 Y 좌표

            // 원근 변환을 하기 전, 압력으로 넣을 꼭지점의 순서와, 출력으로 받을 꼭지점의 순서가 정확하게
            // 일치해야 함, 따라서, 사각형의 중심점(X,Y)를 기준으로 꼭지점을 비교하여 순서를 정함
            // X 값이 크고, Y 값이 크면 우상단 점
            // X 값이 크고, Y 값이 작으면 우하단 점
            // X 값이 작고, Y 값이 크면 좌상단 점
            // X 값이 작고, Y값이 작으면 좌하단 점
            Point2f[] src_pts = new Point2f[4];
            for (int i = 0; i < squares.Length; i++)
            {
                if (cX > squares[i].X && cY > squares[i].Y)
                {
                    src_pts[0] = squares[i];
                }
                if (cX > squares[i].X && cY < squares[i].Y)
                {
                    src_pts[1] = squares[i];
                }
                if (cX < squares[i].X && cY > squares[i].Y)
                {
                    src_pts[2] = squares[i];
                }
                if (cX < squares[i].X && cY < squares[i].Y)
                {
                    src_pts[3] = squares[i];
                }
            }

            // 결과 이미지로 받을 꼭지점의 좌표는 원본 이미지의 전체 크기와 동일하게 설정
            Point2f[] dst_pts = new Point2f[4]
            {
                new Point2f(0, 0),
                new Point2f(0, src.Height),
                new Point2f(src.Width, 0),
                new Point2f(src.Width, src.Height)
            };

            // 검출된 사각형의 꼭지점(scr_pts)을 원본 이미지 크기만큼 원근 변환(dst_pts)
            Mat matrix = Cv2.GetPerspectiveTransform(src_pts, dst_pts);  // 원근 맵 행렬(상수값)을 생성

            // 원근 맵 행렬을 사용하여 검출된 사각형을 원본 이미지 크기와 같게 원근 변환
            Cv2.WarpPerspective(src, dst, matrix, new OpenCvSharp.Size(src.Width, src.Height));
            return (dst);
        }
        #endregion

        #region 문자열 검출
        public static string OCR(Mat src)
        {
            // Mat -> Bitmap 이미지로 변환
            Bitmap bitmap = src.ToBitmap();
          
            // 테서렉트 엔진 인스턴스 생성
            // 두번째 매개변수로 한글("kor"), 영어("eng") 또는 둘다 ("kor+eng")등 감지 언어 선택
            // 세번째 플래그 값으로 엔진의 종류 선택
            // LSTM은 Long Short-Term Memory로 RNN(순환 신경망) 기법의 하나로 음성, 문자 인식에 사용

            TesseractEngine ocr = new TesseractEngine(@"C:\Users\yeeli\source\repos\example_241218\example_250212\tessdata", "eng+kor", EngineMode.LstmOnly);

            // 검출된 텍스트를 Page 객체로 가져옴
            Tesseract.Page texts = ocr.Process(bitmap);

            // Tesseract의 Page를 string으로 변환
            string sentence = texts.GetText().Trim();

            return sentence;
        }
        #endregion

    }
}
