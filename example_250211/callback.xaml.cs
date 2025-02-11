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
    /// Interaction logic for callback.xaml
    /// </summary>
    public partial class callback : System.Windows.Window
    {
        public callback()
        {
            InitializeComponent();

            Mat src = new Mat(new OpenCvSharp.Size(500,500), MatType.CV_8UC3, new Scalar(255,255,255));
            Cv2.ImShow("white board", src);

            MouseCallback cvMouseCallback = new MouseCallback(MyMouseEvent);
            Cv2. SetMouseCallback("white board", cvMouseCallback, src.CvPtr);
            Cv2.WaitKey();
            Cv2.DestroyAllWindows();

            static void MyMouseEvent(MouseEventTypes @event, int x, int y, MouseEventFlags flags, IntPtr userdate)
            {
                if (flags == MouseEventFlags.LButton)
                {
                    MessageBox.Show($"마우스 좌표 {x}, {y}");
                }
            }
        }

        
    }
}
