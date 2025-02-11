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
using OpenCvSharp.Dnn;

namespace example_250211
{
    /// <summary>
    /// Interaction logic for RGBhistogram.xaml
    /// </summary>
    public partial class histogramEqual : System.Windows.Window
    {
        public histogramEqual()
        {
            InitializeComponent();

            string imgPath = "C:\\Users\\yeeli\\source\\repos\\example_241218\\example_250211\\1716427710256.jpg";
            Mat image = Cv2.ImRead(imgPath);

            //원본 사진 흑백으로 전환
            Mat gray = new Mat();
            Cv2.CvtColor(image, gray, ColorConversionCodes.BGR2GRAY);

            // 평탄화 작업
            Mat equal = new Mat();
            Cv2.EqualizeHist(gray, equal);

            // 흑백사진 히스토그램 계산
            Mat grayHist = new Mat();
            int[] histSize = { 256 }; // 히스토그램 크기 (256단계)
            Rangef[] ranges = { new Rangef(0, 256) }; // 픽셀 값 범위 (0~255)
            Cv2.CalcHist(new Mat[] { gray }, new int[] { 0 }, null, grayHist, 1, histSize, ranges);

            // 평탄화사진 히스토그램 계산
            Mat equalHist = new Mat();
            Cv2.CalcHist(new Mat[] { equal }, new int[] { 0 }, null, equalHist, 1, histSize, ranges);

            // 2. 히스토그램 시각화 
            Mat histImage = DrawHistogram(grayHist, new Scalar(255, 255, 255));
            Mat equalhistImage = DrawHistogram(equalHist, new Scalar(255, 255, 255));


            // 3. 결과 이미지 및 히스토그램 출력
            imageBox.Source = OpenCvSharp.WpfExtensions.BitmapSourceConverter.ToBitmapSource(gray);
            imageBox2.Source = OpenCvSharp.WpfExtensions.BitmapSourceConverter.ToBitmapSource(equal);
            Cv2.ImShow("Grayscale Histogram", histImage);
            Cv2.ImShow("Equalization Histogram", equalhistImage);
            
        }
        static Mat DrawHistogram(Mat hist, Scalar color)
        {
            int histWidth = 512, histHeight = 400;
            Mat histImage = new Mat(histHeight, histWidth, MatType.CV_8UC3, Scalar.Black);

            // 히스토그램 정규화 (0~histHeight 범위)
            Cv2.Normalize(hist, hist, 0, histImage.Rows, NormTypes.MinMax);

            // 히스토그램 그리기
            int binWidth = histWidth / hist.Rows;
            for (int i = 1; i < hist.Rows; i++)
            {
                int x1 = (i - 1) * binWidth;
                int y1 = histHeight - (int)hist.At<float>(i - 1);
                int x2 = i * binWidth;
                int y2 = histHeight - (int)hist.At<float>(i);
                Cv2.Line(histImage, new OpenCvSharp.Point(x1, y1), new OpenCvSharp.Point(x2, y2), color, 2);
            }
            return histImage;

        }
    }
}
