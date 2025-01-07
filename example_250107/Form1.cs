using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace example_250107
{
    public partial class Form1 : Form
    {
        Thread[] thread = new Thread[5];
        ProgressBar[] pbs;
        // 랜덤 함수의 씨드가 같으면 랜던값이 같아서 공유해야함
        static Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            #region 프로그래스바 초기 설정            
            pbs = new ProgressBar[5] {num1_progressBar,num2_progressBar,num3_progressBar,num4_progressBar,num5_progressBar};
            for (int i = 0; i < 5; i++) {
                pbs[i].Style = ProgressBarStyle.Continuous;
                pbs[i].Minimum = 0;
                pbs[i].Maximum = 100;
                pbs[i].Step = 1;
                pbs[i].Value = 0;
            }            
            #endregion
        }

        void move(int i)
        {

            Stopwatch sw = new Stopwatch();            
            sw.Start();
            int distance = 0;
            while (distance < 100)
            {
                distance += 10;
                Thread.Sleep(rnd.Next(100, 1000));
                if (pbs[i].InvokeRequired)
                {
                    pbs[i].Invoke(new MethodInvoker(() => { pbs[i].Value = distance; }));
                }
                else
                {
                    pbs[i].Value = distance;
                }
            }
            sw.Stop();
            if (textBox1.InvokeRequired)
            {
                textBox1.Invoke(new MethodInvoker(() => { textBox1.Text += $"{i+1}번 선수 완주~! 걸린 시간:{sw.ElapsedMilliseconds}\r\n"; }));
            }
            else
            {
                textBox1.Text += $"{i+1}번 선수 완주~! 걸린 시간:{sw.ElapsedMilliseconds}\r\n";
            }
            

        }
        private void start_button_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 5; i++)
            {
                int idx = i;  // i의 값이 스레드 때문에 0,1,2,3,4 이렇게 안들어 올 수 있음 그래서 idx에 저장해서 i 값이 변해도 괜찮음!
                thread[idx] = new Thread(() => move(idx));
                thread[idx].Start();
            }

        }
    }
}
