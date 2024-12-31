using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_241230
{
    internal class VendingMachine
    {
        int MachineMoney = 10000;
        int RemainDrink = 5;
        int MachineMoneyLimit = 50000;
        const int DrinkPrice = 1200;
        public bool DrinkButton = false;

        // 돈 받기
        public string ReceiveMoneytoUser(int money) 
        {
            if (money >= DrinkPrice && this.DrinkButton == true)
            {
                return "돈이 투입되었습니다~";
            }
            else
            {
                DrinkButton = false;
                return "투입 금액이 부족합니다ㅠㅠ";
            }
        }
        // 거스름돈 주기
        public string GiveChangetoUser(int money)
        {
            if (DrinkButton == true && money - DrinkPrice <= MachineMoney)
            {
                MachineMoney -= money;
                return (money - DrinkPrice).ToString();
            }
            else if (money - DrinkPrice > MachineMoneyLimit)
            {
                return "잔액이 부족합니다..";
            }
            else
            {
                return "전액 반환합니다";
            }
        }
        // 음료 주기
        public string GiveDrink() 
        {
            if (this.RemainDrink > 0)
            {
                this.RemainDrink--;
                return "음료가 나왔습니다!";
            }
            else
            {
                return "죄송합니다 음료가 부족합니다..";
            }
        }
        
        // 음료 채워짐
        void FillDrinks() { }
        // 돈 채워짐
        void FillMoney() { }
        // 돈 회수당함
        void MoneytoManager() { }
        // 음료 버튼 눌림
        public void PressButton(bool drinkbutton) => this.DrinkButton = drinkbutton;
    }
}
