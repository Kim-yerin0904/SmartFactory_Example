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
using OpenCvSharp;

namespace example_250212
{
    /// <summary>
    /// Interaction logic for Contour.xaml
    /// </summary>
    public partial class Contour : System.Windows.Window
    {
        public Contour()
        {
            InitializeComponent();

            #region contour 실습 1
            Mat src = Cv2.ImRead("C:\\Users\\yeeli\\Downloads\\dog.jpg");
            Cv2.Resize(src, src, new OpenCvSharp.Size(640, 480));
            Mat gray = new Mat();
            Mat binary = new Mat();
            Mat morp = new Mat();
            Mat image = new Mat();
            Mat dst = src.Clone();

            Mat kernel = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(3, 3));

            OpenCvSharp.Point[][] contours;
            HierarchyIndex[] hierarchy;

            Cv2.CvtColor(src, gray, ColorConversionCodes.BGR2GRAY);
            Cv2.Threshold(gray, binary, 200, 255, ThresholdTypes.Binary);
            Cv2.MorphologyEx(binary, morp, MorphTypes.Close, kernel, new OpenCvSharp.Point(-1, -1), 2);
            Cv2.BitwiseNot(morp, image);

            Cv2.FindContours(image, out contours, out hierarchy, RetrievalModes.Tree,
                ContourApproximationModes.ApproxTC89KCOS);
            Cv2.DrawContours(dst, contours, -1, new Scalar(255, 0, 0), 2,
                LineTypes.AntiAlias, hierarchy, 3);

            //for (int i = 0; i < contours.Length; i++)
            //{
            //    for (int j = 0; j < contours[i].Length; j++)
            //    {
            //        Cv2.Circle(dst, contours[i][j], 1, new Scalar(0, 0, 255), 3);
            //    }
            //}
            Cv2.ImShow("contour", dst);
            Cv2.ImShow("binary", binary);
            Cv2.ImShow("morp", morp);
            Cv2.ImShow("bitwise_not", image);

            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
            #endregion

            #region contour 실습2
            //InitializeComponent();
            //string imgPath = "C:\\Users\\yeeli\\source\\repos\\example_241218\\example_250210\\disney.jpg";
            //Mat image = Cv2.ImRead(imgPath);
            //// :앞쪽_화살표: 그레이스케일 변환 (CV_8UC1 이미지만 허용)
            //Mat gray = new Mat();
            //Cv2.CvtColor(image, gray, ColorConversionCodes.BGR2GRAY);
            //// :앞쪽_화살표: 이미지 이진화 (Thresholding)
            //Mat binary = new Mat();
            //Cv2.Threshold(gray, binary, 100, 255, ThresholdTypes.Binary);
            //// :앞쪽_화살표: 윤곽선 검출 (CV_8UC1 이미지 사용)
            //OpenCvSharp.Point[][] contours;
            //HierarchyIndex[] hierarchy;
            //Cv2.FindContours(binary, out contours, out hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            //// :앞쪽_화살표: 윤곽선 그리기 (컬러 이미지 위에 그리기)
            //Mat contourImage = image.Clone();
            //Cv2.DrawContours(contourImage, contours, -1, new Scalar(0, 0, 255), 2);
            //// :앞쪽_화살표: 결과 출력
            //Cv2.ImShow("Original Image", image);
            //Cv2.ImShow("Binary Image", binary);
            //Cv2.ImShow("Contour Detection", contourImage);
            //Cv2.WaitKey(0);
            //Cv2.DestroyAllWindows();
            #endregion
        }
    }
}
