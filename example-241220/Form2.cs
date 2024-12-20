using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_241220
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int userScore = 0;
        int computerScore = 0;
        void finalResultCheck()
        {
            if (computerScore == 3)
            {
                textBoxResult.Text += "\r\n컴퓨터가 승리하였습니다~ 다시 시작하려면 가위 바위 보 버튼을 누르세요!";
                userScore = 0;
                computerScore = 0; 
            }
            else if (userScore == 3)
            {
                textBoxResult.Text += "\r\n예린이가 승리하였습니다~ 다시 시작하려면 가위 바위 보 버튼을 누르세요!";
                userScore = 0;
                computerScore = 0;
            }
            else
            {
                return;
            }
        }
        void RockScissorsPaperGame(string userChoice)
        {
            Random rand = new Random();
            int randNum = rand.Next(3);
            string computerChoice;
            // 컴퓨터가 뭐낼지 고르기
            if (randNum == 0)
            {
                computerChoice = "가위";
            }
            else if (randNum == 1)
            {
                computerChoice = "바위";
            }
            else
            {
                computerChoice = "보";
            }

            //가위바위보 결과 출력
            if (computerChoice == userChoice)
            {
                textBoxResult.Text = "컴퓨터 : " + computerChoice + "\r\n";
                textBoxResult.Text += "무승부입니다~\r\n";
                textBoxResult.Text += "현재 스코어 : 컴퓨터=" + computerScore + "예린:" + userScore;
                finalResultCheck();

            }
            else if ((computerChoice == "가위" && userChoice == "보") ||
                (computerChoice == "바위" && userChoice == "가위") ||
                (computerChoice == "보" && userChoice == "주먹"))
            {
                computerScore += 1;
                textBoxResult.Text = "컴퓨터 : " + computerChoice + "\r\n";
                textBoxResult.Text += "패배했습니다ㅠ\r\n";
                textBoxResult.Text += "현재 스코어 : 컴퓨터=" + computerScore + "예린:" + userScore;
                finalResultCheck();
            }
            else
            {
                userScore += 1;
                textBoxResult.Text = "컴퓨터 : " + computerChoice + "\r\n";
                textBoxResult.Text += "승리했습니다!!\r\n";
                textBoxResult.Text += "현재 스코어 : 컴퓨터=" + computerScore + "예린:" + userScore;
                finalResultCheck();
            }
        }
        private void buttonScissors_Click(object sender, EventArgs e)
        {
            string userChoice = "가위";
            RockScissorsPaperGame(userChoice);
        }

        private void buttonRock_Click(object sender, EventArgs e)
        {
            string userChoice = "바위";
            RockScissorsPaperGame(userChoice);
        }

        private void buttonPaper_Click(object sender, EventArgs e)
        {
            string userChoice = "보";
            RockScissorsPaperGame(userChoice);
        }
    }
}
