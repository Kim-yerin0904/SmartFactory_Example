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
        public Form1()
        {
            InitializeComponent();
            bool coinSide = false;
            bool result = FlippingCoins(coinSide);
            if (result == true)
            {
                textBoxResult.Text = "승리";
            }
            else
            {
                textBoxResult.Text = "패배";
            }
            
        }

        bool FlippingCoins(bool x)
        {
            Random rnd = new Random();
            int randomNum  = rnd.Next();
            int result = randomNum % 2;
            if (result == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        #endregion
    }
}
