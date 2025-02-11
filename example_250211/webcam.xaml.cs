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
    /// Interaction logic for videocapture.xaml
    /// </summary>
    public partial class webcam : System.Windows.Window
    {
        public webcam()
        {
            InitializeComponent();

            VideoCapture capture = new VideoCapture(0);
            Mat frame = new Mat();

            capture.Set(VideoCaptureProperties.FrameWidth, 640);
            capture.Set(VideoCaptureProperties.FrameHeight, 480);

            while (true)
            {
                if (capture.IsOpened() == true)
                {
                    capture.Read(frame);
                    Cv2.ImShow("Webcam", frame);

                    if (Cv2.WaitKey(33) == 'q') break;
                }
            }

            capture.Release();
            Cv2.DestroyAllWindows();
        }
    }
}
