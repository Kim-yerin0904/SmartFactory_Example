using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_241230
{
    public partial class Form1 : Form
    {
        User user = new User();
        Manager manager = new Manager();
        VendingMachine machine = new VendingMachine();
        public Form1()
        {
            InitializeComponent();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(inputMoney.Text, out int money))
            {
                machine.PressButton(user.PressButton());
                user.MoneyToMachine(money);
                resultBox.Text += machine.ReceiveMoneytoUser(money);
                if (int.TryParse(machine.GiveChangetoUser(money), out int change))
                {
                    changePrint.Text = change.ToString();
                    resultBox.Text += "거스름돈을 받아주세요";
                    resultBox.Text += machine.GiveDrink();
                }
                else
                {
                    resultBox.Text += machine.GiveChangetoUser(money);
                }
                
            }
            else
            {
                resultBox.Text = "금액만 입력해주세요!";
            }

        }
    }
}
