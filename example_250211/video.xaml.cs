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
    /// Interaction logic for video.xaml
    /// </summary>
    public partial class video : System.Windows.Window
    {
        public video()
        {
            InitializeComponent();

            VideoCapture capture = new VideoCapture("C:\\Users\\yeeli\\source\\repos\\example_241218\\example_250211\\20240414_170148.mp4");
            Mat frame = new Mat();

            
            while (true)
            {
                
                if (capture.PosFrames == capture.FrameCount) capture.Open("C:\\Users\\yeeli\\source\\repos\\example_241218\\example_250211\\20240414_170148.mp4");

                capture.Read(frame);
                // 영상 사이즈 조절
                Cv2.Resize(frame, frame, new OpenCvSharp.Size(frame.Width * 1/5, frame.Height * 1/5));
                Cv2.ImShow("video", frame);

                if (Cv2.WaitKey(33) == 'q') break;
            }

            capture.Release();
            Cv2.DestroyAllWindows();   
        }
    }
}
