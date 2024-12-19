using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_241219
{
    public partial class Form1 : Form
    {
        // Form1()은 생성 시 최초 1회만 실행
        public Form1()
        {
            InitializeComponent();
        }
        public enum sevenDays
        {
            월요일,
            화요일,
            수요일,
            목요일,
            금요일,
            토요일,
            일요일
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] days = { "월요일", "화요일", "수요일", "목요일", "금요일", "토요일", "일요일" };
            if (days.Contains(textBoxInput.Text))
            {
                string day = textBoxInput.Text;
                sevenDays dayenum = (sevenDays)Enum.Parse(typeof(sevenDays), day);
                switch (dayenum)
                {
                    case sevenDays.월요일:
                        textBoxResult.Text = "월요일은 ~";
                        break;
                    case sevenDays.화요일:
                        textBoxResult.Text = "화요일";
                        break;
                    case sevenDays.수요일:
                        textBoxResult.Text = "수요일";
                        break;
                    case sevenDays.목요일:
                        textBoxResult.Text = "목요일";
                        break;
                    case sevenDays.금요일:
                        textBoxResult.Text = "금요일";
                        break;
                    case sevenDays.토요일:
                        textBoxResult.Text = "토요일";
                        break;
                    case sevenDays.일요일:
                        textBoxResult.Text = "일요일";
                        break;
                }
            }
            else
            {
                textBoxResult.Text = "요일만 입력해주세요! ex.수요일/";
            }
                
        }
    }
}
