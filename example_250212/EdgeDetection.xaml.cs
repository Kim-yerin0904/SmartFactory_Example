using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using OpenCvSharp;

namespace example_250212
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class EdgeDetection : System.Windows.Window
    {
        public EdgeDetection()
        {
            InitializeComponent();
            string imgpath = "C:\\Users\\yeeli\\source\\repos\\example_241218\\example_250210\\disney.jpg";
            Mat image = Cv2.ImRead(imgpath);

            // sobel 엣지 검출
            Mat sobelX = new Mat(), sobelY = new Mat(), sobel = new Mat();
            Cv2.Sobel(image, sobelX, MatType.CV_64F, 1, 0, ksize: 3);
            Cv2.Sobel(image, sobelY, MatType.CV_64F, 0, 1, ksize: 3);
            Cv2.ConvertScaleAbs(sobelX,sobelX);
            Cv2.ConvertScaleAbs(sobelY, sobelY);
            Cv2.AddWeighted(sobelX, 0.5, sobelY, 0.5, 0, sobel);

            // Scharr 엣지 검출
            Mat scharrX = new Mat(), scharrY= new Mat(), scharr = new Mat();
            Cv2.Scharr(image, scharrX, MatType.CV_64F, 1, 0);
            Cv2.Scharr(image, scharrY, MatType.CV_64F, 0, 1);
            Cv2.ConvertScaleAbs(scharrX, scharrX);  
            Cv2.ConvertScaleAbs(scharrY, scharrY);
            Cv2.AddWeighted(scharrX,0.5,scharrY,0.5, 0, scharr);   

            // Laplacian 엣지 검출
            Mat laplacian = new Mat();
            Cv2.Laplacian(image, laplacian, MatType.CV_64F);
            Cv2.ConvertScaleAbs(laplacian, laplacian);

            // Canny 엣지 검출
            Mat canny = new Mat();
            Cv2.Canny(image, canny, 50, 150);

            // 결과 출력
            originalBox.Source = OpenCvSharp.WpfExtensions.BitmapSourceConverter.ToBitmapSource(image);
            sobelBox.Source = OpenCvSharp.WpfExtensions.BitmapSourceConverter.ToBitmapSource(sobel);
            scharrBox.Source = OpenCvSharp.WpfExtensions.BitmapSourceConverter.ToBitmapSource(scharr);
            laplacianBox.Source = OpenCvSharp.WpfExtensions.BitmapSourceConverter.ToBitmapSource(laplacian);
            cannyBox.Source = OpenCvSharp.WpfExtensions.BitmapSourceConverter.ToBitmapSource(canny);


        }

    }
}