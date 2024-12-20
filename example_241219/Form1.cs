using System;
using System.Linq;
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
        enum sevenDays
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
                // tryparse 사용법
                //if (Enum.TryParse(day,true,out sevenDays))
                //{
                //    //
                //}
                //else
                //{
                //    // tryparse니까 안될 경우를 생각해야함
                //}
                sevenDays dayenum = (sevenDays)Enum.Parse(typeof(sevenDays), day);
                switch (dayenum)
                {
                    case sevenDays.월요일:
                        textBoxResult.Text = "월요일은 분명 출근하긴 했는데 뭐했는지 기억이 없는 날";
                        break;
                    case sevenDays.화요일:
                        textBoxResult.Text = "화요일은 화장실 가는 척하면서 집 가고 싶은 날";
                        break;
                    case sevenDays.수요일:
                        textBoxResult.Text = "수요일은 수틀리면 사직서 내고 싶은 날";
                        break;
                    case sevenDays.목요일:
                        textBoxResult.Text = "목요일은 금요일인 줄 알고 있다가 아닌 거 알고 혼자 화나는 날";
                        break;
                    case sevenDays.금요일:
                        textBoxResult.Text = "금요일 모든 일이 안됐지만 월요일의 나에게 부탁하고 튀는 날";
                        break;
                    case sevenDays.토요일:
                        textBoxResult.Text = "토요일은 나갈까 말까 고민하다가 결국 아무것도 안 하는 날";
                        break;
                    case sevenDays.일요일:
                        textBoxResult.Text = "일요일은 주말인데 괜히 심란한 날";
                        break;
                }
            }
            else
            {
                textBoxResult.Text = "요일만 입력해주세요! ex.수요일";
            }

        }
    }
}
