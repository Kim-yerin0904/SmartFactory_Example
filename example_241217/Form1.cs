using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_241217
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #region 배열실습
            // 실습1
            //string[] result = new string[10];
            //result[0] = "동해 물과 백두산이".IndexOf("백두산").ToString();
            //result[1] = "토요일에 먹는 토마토".LastIndexOf("토").ToString();
            //result[2] = "질서 있는 퇴장".Contains("퇴").ToString();
            //result[3] = "그 사람의 그림자는 그랬다.".Replace("그","이");
            //result[4] = "삼성 갤럭시".Insert(2, "애플");
            //result[5] = "오늘은 왠지 더 배고프다".Remove(7,1);
            //string[] words = "이름,나이,전화번호".Split(',');
            //for (int i=0; i<words.Length; i++)
            //{
            //    result[i+6] = words[i];
            //}
            //result[9] = "우리 나라 만세".Substring(3,2);

            //foreach(string a in result)
            //{
            //    textBox1.Text += a+"\r\n";
            //}
            #endregion

            #region 문자열실습
            //실습2 
            string exampleSentence = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";
            string[] resultArray = new string[5];
            //1-1
            int index = exampleSentence.IndexOf('-');
            resultArray[0] = exampleSentence.Substring(0, index - 1);
            //1-2
            int startIndex = exampleSentence.IndexOf("얼마나");
            int endIndex = exampleSentence.LastIndexOf("가는지는");
            string slicedSentence = exampleSentence.Substring(startIndex, endIndex);
            string[] temp = slicedSentence.Split(' ');
            for (int i = 0; i < temp.Length; i++)
            {
                resultArray[i + 1] = temp[i];
            }
            //1-3
            int index1 = exampleSentence.IndexOf('-');
            int index2 = exampleSentence.IndexOf('.');
            string newSentence = exampleSentence.Remove(index1, 1);
            newSentence = newSentence.Remove(index2, 1);
            resultArray[4] = newSentence.Replace(' ', ',');
            //2
            foreach (string s in resultArray)
            {
                textBox1.Text += s + "\r\n";
            }
            #endregion
        }

    }
}
}
