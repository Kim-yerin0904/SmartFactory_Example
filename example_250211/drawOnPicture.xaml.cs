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
    /// Interaction logic for drawOnPicture.xaml
    /// </summary>
    public partial class drawOnPicture : System.Windows.Window
    {
        public drawOnPicture()
        {
            InitializeComponent();

            string imgPath = "C:\\Users\\yeeli\\source\\repos\\example_241218\\example_250210\\disney.jpg";
            Mat image = Cv2.ImRead(imgPath);

            Mat target0 = new Mat();
            Cv2.CvtColor(image, target0, ColorConversionCodes.BGRA2BGR);

            string text = "~Disney~";
            OpenCvSharp.Point textposition = new OpenCvSharp.Point(50,100);
            Cv2.PutText(target0, text, textposition, HersheyFonts.HersheySimplex, 3, new Scalar(255, 255, 255), 4, LineTypes.AntiAlias);

            imageBox.Source = OpenCvSharp.WpfExtensions.BitmapSourceConverter.ToBitmapSource(target0);

        }
    }
}
