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
                MessageBox.Show("몬스터가 죽었습니다!");
                monster = new Slime();
                player = new Warrior();
                player_label.Text = player.showName();
                player_strength.Text = player.showstrength();
                monster_strength_label.Text = monster.showstrength();
            }
                
            


        }
    }
}
