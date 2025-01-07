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
using System.IO;

namespace example_250106
{
    public partial class Form2 : Form
    {
        BackgroundWorker worker;
        string[] files;
        public Form2()
        {
            InitializeComponent();
            
            this.worker = new BackgroundWorker();
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;

            this.worker.DoWork += new DoWorkEventHandler(search);
            this.worker.ProgressChanged += new ProgressChangedEventHandler(result);
        }
        void search(object sender, DoWorkEventArgs e)
        {
            string path = textBox_directory.Text;
            string type = textBox_type.Text;
            files = Directory.GetFiles(path, type, SearchOption.AllDirectories);
            for (int i = 0; i < files.Length; i++)
            {
                this.worker.ReportProgress(i);
                Thread.Sleep(100);
            }
        }
        void result(object sender, ProgressChangedEventArgs e)
        {
            listBox1.Items.Add(files[e.ProgressPercentage]);
        }

        void complete(object sender, EventArgs e)
        {
            MessageBox.Show("검색 완료!");
        }
        
        private void input_button_Click(object sender, EventArgs e)
        {
            if (!this.worker.IsBusy)
            {
                this.worker.RunWorkerAsync();
            }
        }
    }
}
