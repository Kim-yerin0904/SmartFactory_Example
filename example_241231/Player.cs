using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_241231
{
    internal class NPC
    {
        string name;

        public string giveMission()
        {
            return "오크 3마리, 슬라임 1마리";
        }
    }

    internal class Player
    {
        protected int strength;
        protected string name;
        int catchOrc = 0;
        int catchSlime = 0;

        public Player() { }
        public Player(string name) : this()
        {
            this.name = name;
        }
        public int basicattack()
        {
            return 12;
        }
        public int damage(int monsterattack)
        {
            this.strength -= monsterattack;
            return this.strength;
        }
        string[] receiveMission(string mission)
        {
            string[] missioncount = new string[2];
            missioncount[0] = mission.Substring(3, 1);
            missioncount[1] = mission.Substring(-3, 1);
            return missioncount;
        }
        //form에 띄우기 용
        public string showName() { return this.name; }
        public string showstrength() { return (this.strength).ToString(); }
    }
    internal class Wizard : Player
    {
        public Wizard() 
        {
            this.name = "마법사";
            this.strength = 100;
        }
        public Wizard(string name) : base(name) 
        { 
            this.name = this.name.Insert(0,"마.");
            this.strength = 100; 
        }
        public int magicAttack() { return 35; }
    }

    internal class Warrior : Player
    {
        public Warrior() 
        {
            this.name = "검사";
            this.strength = 150;
        }
        public Warrior(string name) : base(name) 
        {
            this.name = this.name.Insert(0, "검.");
            this.strength = 150;
        }
        public int swordAttack() { return 25; }
    }
}
