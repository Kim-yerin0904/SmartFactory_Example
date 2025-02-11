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

namespace example_250211
{
    /// <summary>
    /// Interaction logic for figure.xaml
    /// </summary>
    public partial class figure : System.Windows.Window
    {
        public figure()
        {
            InitializeComponent();

            // 새로운 이미지 생성
            Mat draw = new Mat(new OpenCvSharp.Size(640,360), MatType.CV_8UC3, Scalar.All(255));

            // 선그리기 
            Cv2.Line(draw, new OpenCvSharp.Point(10, 10), new OpenCvSharp.Point(600, 10), Scalar.Red, 10, LineTypes.AntiAlias);
            Cv2.Line(draw, new OpenCvSharp.Point(10, 30), new OpenCvSharp.Point(630, 30), Scalar.Orange, 10, LineTypes.AntiAlias);

            // 원그리기
            Cv2.Circle(draw, new OpenCvSharp.Point(30, 70), 20, Scalar.Yellow, 10, LineTypes.AntiAlias);
            Cv2.Circle(draw, new OpenCvSharp.Point(90, 70), 50, Scalar.Green, 1, LineTypes.AntiAlias);

            // 사각형 그리기
            Cv2.Rectangle(draw, new OpenCvSharp.Rect(130,50,40,40), Scalar.Blue, 10, LineTypes.AntiAlias);  // x,y = 130,50에 가로세로 40인 사각형
            Cv2.Rectangle(draw, new OpenCvSharp.Point(185,45), new OpenCvSharp.Point(235,115), Scalar.Navy, -1, LineTypes.AntiAlias);  

            //타원 그리기
            Cv2.Ellipse(draw, new RotatedRect(new Point2f(290,70), new Size2f(75,50), 30), Scalar.Purple, 10, LineTypes.AntiAlias);

            // 결과 표시
            Cv2.ImShow("Drawn Shapes", draw);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
        }
    }
}
