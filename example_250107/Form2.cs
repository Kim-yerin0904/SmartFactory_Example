using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace example_250107
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        async Task<string> ReadFileAsync(string filepath)
        {
            var sr = new StreamReader(filepath);
            string content = sr.ReadToEnd();
            return content;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();
            string filepath;
            if (dr == DialogResult.OK)
            {
                filepath = ofd.FileName;
                string result = await ReadFileAsync(filepath);
                if (textBox1.InvokeRequired)
                {
                    textBox1.Invoke((Action)(() => { textBox1.Text += result; }));
                }
                else
                {
                    textBox1.Text += result;
                }
            }
            else
            {
                filepath = "";
            }
            
        }
    }
}
