using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_241230
{
    internal class User
    {
        int UserMoney = 100000;

        //기본 생성자
        public User()
        {
            MessageBox.Show("손님 등장~");
        }

        // 자판기에 돈 넣기
        public void MoneyToMachine(int money) => UserMoney -= money;
        // 음료 버튼 누르기
        public bool PressButton()
        {   
            bool drinkbutton = true;
            return drinkbutton;
        }
        // 잔돈 받기
        void ReceiveChange(string change)
        {
            UserMoney += int.Parse(change);
        }
        // 음료 받기
        void ReceiveDrink()
        {

        }
    }
}
