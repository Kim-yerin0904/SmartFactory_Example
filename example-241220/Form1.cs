using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_241220
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void MakeResultSentence (string studentName, int Score)
        {
            textBoxResult.Text += studentName + ":" + Score + "점\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            int studentCount = int.Parse(textBoxInput.Text);
            Random rand = new Random();
            for (int i = 1; i < studentCount+1; i++)
            {
                int score = rand.Next(101);
                string studentName = "학생" + i.ToString();
                MakeResultSentence(studentName, score);
            }
        }
    }
}
