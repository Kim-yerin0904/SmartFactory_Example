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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        void MakeResultSentence(string studentName, int Score)
        {
            textBoxResult.Text += studentName + " : " + Score + "점\r\n";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
            int studentCount = 0;
            if (int.TryParse(textBoxInput.Text, out studentCount))
            {
                Random random = new Random();
                int i = 1;
                while (i <= studentCount)
                {
                    int score = random.Next(0, 101);
                    string studentName = "학생" + i.ToString();
                    MakeResultSentence(studentName, score);
                    i++;
                }
            }
            // 충돌나게 하기~
            int conlict;
        }
    }
}
