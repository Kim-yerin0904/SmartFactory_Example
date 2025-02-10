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
using OpenCvSharp;

namespace example_250210
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textbox.Text = Cv2.GetVersionString();
            Mat image = Cv2.ImRead("C:\\Users\\yeeli\\source\\repos\\example_241218\\example_250210\\disney.jpg");
            Cv2.ImShow("Image test", image);
            imageBox.Source = OpenCvSharp.WpfExtensions.BitmapSourceConverter.ToBitmapSource(image);

            Mat image1 = new Mat(image.Size(), MatType.CV_8UC1);
            Mat image2 = new Mat();
            Mat image3 = new Mat();
            Mat image4 = new Mat();
            Mat image5 = new Mat();

            Cv2.CvtColor(image, image1, ColorConversionCodes.BGR2GRAY);
            Cv2.CvtColor(image, image2, ColorConversionCodes.BGR2HSV);
            Cv2.CvtColor(image, image3, ColorConversionCodes.BGR2HLS);
            Cv2.CvtColor(image, image4, ColorConversionCodes.BGR2RGBA);
            Cv2.CvtColor(image, image5, ColorConversionCodes.BGR2Lab);

            imageBox1.Source = OpenCvSharp.WpfExtensions.BitmapSourceConverter.ToBitmapSource(image1);
            imageBox2.Source = OpenCvSharp.WpfExtensions.BitmapSourceConverter.ToBitmapSource(image2);
            imageBox3.Source = OpenCvSharp.WpfExtensions.BitmapSourceConverter.ToBitmapSource(image3);
            imageBox4.Source = OpenCvSharp.WpfExtensions.BitmapSourceConverter.ToBitmapSource(image4);
            imageBox5.Source = OpenCvSharp.WpfExtensions.BitmapSourceConverter.ToBitmapSource(image5);


        }
    }
}