using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_250106
{
    public partial class Form1 : Form
    {
        BackgroundWorker worker;

        public Form1()
        {
            InitializeComponent();

            // 프로그래스 바 초기 설정
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 0;

            #region BackgroundWorker 실습
            this.worker = new BackgroundWorker();
            // ReportProgress 메소드 활용 여부
            this.worker.WorkerReportsProgress = true;
            // CancelAsync()로 BackgroundWorker를 멈출 수 있게 할지, 보통 true
            this.worker.WorkerSupportsCancellation = true;

            // BackgroundWorker가 ui스레드와 별개로 수행할 메소드
            this.worker.DoWork += new DoWorkEventHandler(Worker_Dowork);
            // ReportProgress() 메소드가 수행될 때 실행될 메소드
            this.worker.ProgressChanged += new ProgressChangedEventHandler(Worker_ProgressChanged);
            // ReportProgress()가 100을 호출되면 마지막에 한 번 실행되는 메소드
            this.worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Worker_Complete);
            #endregion
        }

        #region BackgroundWorker 실습
        void Worker_Dowork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(150);
                this.worker.ReportProgress(i);
            }
        }
        void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progresspercentage는 0~100 사아의 값을 가짐
            progressBar1.Value = e.ProgressPercentage;
        }
        void Worker_Complete(object sender, EventArgs e)
        {
            MessageBox.Show("완료!");
        }
        #endregion

        private void startbutton_Click(object sender, EventArgs e)
        {
            #region 프로그래스바 채워보기~
            // while 문으로 처리할 경우 UI 스레드 내부에서 실행
            // ui 스레드가 바쁠 경우 응답 없음 상태로 멈추고
            //while (true)
            //{
            //    progressBar1.Value += 1;
            //    if (progressBar1.Value >= 100) break;
            //}
            #endregion

            #region BackgroundWorker 실습
            if (!this.worker.IsBusy)
            {
                // DoWork가 실행됨
                this.worker.RunWorkerAsync();
            }
            #endregion
        }
    }
}
