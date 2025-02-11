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
    /// Interaction logic for DrawingwithMouse.xaml
    /// </summary>
    public partial class DrawingwithMouse : System.Windows.Window
    {
        public DrawingwithMouse()
        {
            InitializeComponent();

            string imgpath = "C:\\Users\\yeeli\\source\\repos\\example_241218\\example_250211\\1716427710256.jpg";
            Mat image = Cv2.ImRead(imgpath);

            Cv2.ImShow("Drawing", image);

            MouseCallback cvMouseCallback = new MouseCallback(ClickDrawing);
            Cv2.SetMouseCallback("Drawing", cvMouseCallback, image.CvPtr);
            Cv2.WaitKey();
            Cv2.DestroyAllWindows();


            void ClickDrawing(MouseEventTypes @event, int x, int y, MouseEventFlags flags, IntPtr userdata)
            {
                if (flags == MouseEventFlags.LButton)
                {
                    Cv2.Circle(image, new OpenCvSharp.Point(x, y), 5, Scalar.Yellow, 10, LineTypes.AntiAlias);
                    Cv2.ImShow("Drawing", image);
                }
            }
        }

        
    }
}
