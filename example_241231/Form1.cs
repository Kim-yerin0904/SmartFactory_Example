using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_241231
{
    public partial class Form1 : Form
    {
        NPC npc = new NPC();
        Player player = new Wizard();
        Monster monster = new Orc();

        public Form1()
        {
            InitializeComponent();
            player_label.Text = player.showName();
            player_strength.Text = player.showstrength();
            monster_label.Text = "오크";
            monster_strength_label.Text = monster.showstrength();
        }

        private void attack_button_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int userattack;
            int monsterattack;
            int monsterheal;
            if (int.Parse(monster_strength_label.Text) > 0 && int.Parse(player_strength.Text) > 0)
            {
                // player공격
                if (rand.Next(1,4) == 2 && player_label.Text[0] == '마')
                {
                    userattack = ((Wizard)player).magicAttack();

                }
                else if (rand.Next(1, 4) == 3 && player_label.Text[0] == '검')
                {
                    userattack = ((Warrior)player).swordAttack();
                }
                else
                {
                    userattack = player.basicattack();
                }
                monster_strength_label.Text = (monster.damage(userattack)).ToString();
                user_attack_label.Text = userattack.ToString();

                //monster 공격
                if (rand.Next(1, 6) == 3 && monster_label.Text[0] == '오')
                {
                    monsterattack = ((Orc)monster).doubleAttack();
                    
                }
                else if (rand.Next(1, 6) == 5 && monster_label.Text[0] == '슬')
                {
                    monsterheal = ((Slime)monster).heal();
                    monsterattack = 0;
                    monster_strength_label.Text = monsterheal.ToString();
                }
                else
                {
                    monsterattack = monster.attack();
                }
                player_strength.Text = (player.damage(monsterattack)).ToString();
                monster_attack_label.Text = monsterattack.ToString();
            }
            else if (int.Parse(player_strength.Text) < int.Parse(monster_strength_label.Text))
            {
                MessageBox.Show("플레이어가 죽었습니다ㅠㅠ");
                player = new Warrior();
                player_label.Text = player.showName();
                player_strength.Text = player.showstrength();
                
                monster = new Orc();
                monster_strength_label.Text = monster.showstrength();

            }
            else
            {
                //오버라이드 Talk()
                monster.Talk();
                monster = new Slime();
                monster_label.Text = "슬라임";
                monster_strength_label.Text = monster.showstrength();

                player = new Warrior();
                player_label.Text = player.showName();
                player_strength.Text = player.showstrength();
                
            }
        }
        #region 오버로드 실습
        private void change_button_Click(object sender, EventArgs e)
        {
            if (name_change_box.Text=="" && strength_change_box.Text == "")
            {
                MessageBox.Show("아무것도 입력된 것이 없습니다,,");
            }
            else if (name_change_box.Text != "" && strength_change_box.Text == "")
            {
                player_label.Text = player.Change(name_change_box.Text);
            }
            else if (strength_change_box.Text != "" && name_change_box.Text == "")
            {
                if (int.TryParse(strength_change_box.Text, out int hp))
                {
                    player_strength.Text = player.Change(hp).ToString();
                }
                else
                {
                    MessageBox.Show("숫자를 입력해주세요!");
                }
            }
            else
            {
                if (int.TryParse(strength_change_box.Text, out int hp))
                {
                    string[] result = new string[2];
                    result = player.Change(name_change_box.Text, hp);
                    player_label.Text = result[0];
                    player_strength.Text = result[1];
                }
                else
                {
                    MessageBox.Show("체력은 숫자로 입력해주세요!");
                }     
            }
        }
        #endregion
    }
}
