using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
using OpenCvSharp;

namespace example_250210
{
    /// <summary>
    /// Interaction logic for histogram.xaml
    /// </summary>
    public partial class histogram : System.Windows.Window
    {
        public histogram()
        {
            InitializeComponent();

            // 이미지 파일 경로
            string imageFilePath = "C:\\Users\\yeeli\\source\\repos\\example_241218\\example_250210\\disney.jpg";
            // Mat = matrix = 2차원 행렬
            Mat src = Cv2.ImRead(imageFilePath);  //원본
            Mat gray = new Mat();  // 흑백
            Mat hist = new Mat();  // 히스토그램

            // 가로 256, 세로 이미지 크기 만큼 1로만 가득 차 있는 매트릭스 생성
            Mat result = Mat.Ones(new OpenCvSharp.Size(256, src.Height), MatType.CV_8UC1);  // 8bit 1channel 이미지
            Mat dst = new Mat();

            Cv2.CvtColor(src, gray, ColorConversionCodes.BGR2GRAY);

            // 히스토그램 값 생성
            // 원본 매트릭스, 채널 수, 이미지 마스크, 출력 매트릭스, 차원 수, 히스토그램(가로), 각 자원에 대한 색상값 범위
            Cv2.CalcHist(new Mat[] { gray }, new int[] { 0 }, null, hist, 1, new int[] { 256 }, new Rangef[] { new Rangef(0, 256) });

            // 값의 범위를 정규화 (최소값 60~최대값 210이였다면, 최소값 0~최대값 255로 변환)
            // 원본 매트릭스, 출력 매트릭스, 최소값(MinMax일 경우), 최대값(MinMax일 경우, 변환 공식
            Cv2.Normalize(hist, hist, 0, 255, NormTypes.MinMax);

            // 히스토그램 값을 갖고 깂의 크기만큼 선의 길이를 정하고 선을 그림
            for (int i = 0; i < hist.Rows; i++)
            {
                Cv2.Line(result, new OpenCvSharp.Point(i, src.Height),
                    new OpenCvSharp.Point(i, src.Height - hist.Get<float>(i)), Scalar.White);
            }

            // 가로로 매트릭스 두개를 붙이기 (높이가 같아야만 가능)
            Cv2.HConcat(new Mat[] { gray, result }, dst);

            imageBox.Source = OpenCvSharp.WpfExtensions.BitmapSourceConverter.ToBitmapSource(dst);

            //사용자 입력이 들어오면 창을 모두 닫기
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
        }
    }
}
