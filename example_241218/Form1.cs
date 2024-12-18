using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace example_241218
{
    public partial class Form1 : Form
    {
        #region 함수실습 나누기함수만들기
        //public Form1()
        //{
        //    InitializeComponent();
        //    int x = 26;
        //    int y = 3;
        //    int[] result = DivisionQuotientRemain(x, y);
        //    textBoxResult.Text = "몫: " + result[0].ToString() +"\r\n";
        //    textBoxResult.Text += "나머지: " + result[1].ToString();

        //}

        //int[] DivisionQuotientRemain(int x, int y)
        //{
        //    int[] results = new int[2];
        //    results[0] = x / y;
        //    results[1] = x % y;
        //    return results;
        //}
        #endregion

        #region if문 실습
        //public Form1()
        //{
        //    InitializeComponent();
        //    bool coinSide = false;
        //    bool result = FlippingCoins(coinSide);
        //    if (result == true)
        //    {
        //        textBoxResult.Text = "승리";
        //    }
        //    else
        //    {
        //        textBoxResult.Text = "패배";
        //    }

        //}

        //bool FlippingCoins(bool x)
        //{
        //    Random rnd = new Random();
        //    int randomNum = rnd.Next();
        //    int result = randomNum % 2;
        //    // int를 bool로 변환하기
        //    bool resultBool = Convert.ToBoolean(result);
        //    if (resultBool == x)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        #endregion

        #region 사용자입력박스&버튼만들기
        //public Form1()
        //{
        //    InitializeComponent();
        //}
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    textBoxResult.Text = textBox_input.Text;
        //}
        #endregion

        #region 사용자입력받기+동전던지기
        public Form1()
        {
            InitializeComponent();
        }
        // 동전 던져 비교 함수
        bool FlippingCoins(bool x)
        {
            Random rnd = new Random();
            int randomNum = rnd.Next();
            int ramain = randomNum % 2;
            // int를 bool로 변환하기
            bool randCoinSide = Convert.ToBoolean(ramain);
            if (randCoinSide == x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // 결과 문장 출력 함수
        void MakeResultSentence (string userchoice, bool finalResult)
        {
            textBoxResult.Text = "입력하신 값은" + userchoice + "입니다!\r\n";
            textBoxResult.Text += "동전 던지기 결과...\r\n";
            if (finalResult == true)
            {
                textBoxResult.Text += "승리~!";
            }
            else
            {
                textBoxResult.Text += "패배...";
            }
        }
        // input 버튼 클릭 시
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_input.Text == "false" || textBox_input.Text == "true")
            {
                bool finalResult = FlippingCoins(Convert.ToBoolean(textBox_input.Text));
                MakeResultSentence(textBox_input.Text, finalResult);
            }
            else
            {
                textBoxResult.Text = "true나 false 둘 중에 하나로 골라주세요~";
            }
        }
        // true 라디오 버튼 클릭 시
        private void radioButtonTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox_input.Text == "")
            {
                bool finalResult = FlippingCoins(false);
                MakeResultSentence("true", finalResult);
            }
            else
            {
                if (textBox_input.Text == "false" || textBox_input.Text == "true")
                {
                    bool finalResult = FlippingCoins(Convert.ToBoolean(textBox_input.Text));
                    MakeResultSentence(textBox_input.Text, finalResult);
                }
                else
                {
                    textBoxResult.Text = "true나 false 둘 중에 하나로 골라주세요~";
                }
            }
        }
        // false 라디오 버튼 클릭 시
        private void radioButtonFalse_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox_input.Text == "")
            {
                bool finalResult = FlippingCoins(true);
                MakeResultSentence("false", finalResult);
            }
            else
            {
                if (textBox_input.Text == "false" || textBox_input.Text == "true")
                {
                    bool finalResult = FlippingCoins(Convert.ToBoolean(textBox_input.Text));
                    MakeResultSentence(textBox_input.Text, finalResult);
                }
                else
                {
                    textBoxResult.Text = "true나 false 둘 중에 하나로 골라주세요~";
                }
            }
            
        }
        #endregion
    }
}
