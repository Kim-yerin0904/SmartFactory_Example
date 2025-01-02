using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_241231
{
    internal class Monster
    {
        protected int strength;
        protected int attackstrength;

        protected Monster() { }
        public int attack()
        {
            return this.attackstrength;
        }

        public int damage(int userattack)
        {
            this.strength -= userattack;
            return this.strength;
        }

        #region 오버라이드 실습
        public virtual void Talk()
        {
            MessageBox.Show("윽 몬스터가 죽다니.. ");
        }
        #endregion

        //form 띄우기 용
        public string showstrength() { return strength.ToString(); }
    }

    internal class Orc : Monster
    {
        public Orc() 
        {
            this.strength = 100;
            this.attackstrength = 15;
            MessageBox.Show("오크가 등장했다!");
        }
        public int doubleAttack() { return attackstrength*2; }

        #region 오버라이드 실습
        public override void Talk()
        {
            MessageBox.Show("으... 오크가 죽다니.. ");
        }
        #endregion
    }


    internal class Slime : Monster
    {
        public Slime()
        {
            this.strength = 80;
            this.attackstrength = 10;
            MessageBox.Show("슬라임이 등장했다!");
        }
        public int heal() 
        { 
            this.strength += 20;
            return this.strength;
        }

        #region 오버라이드 실습
        public override void Talk()
        {
            MessageBox.Show("슬라임이 죽다니,,");
        }
        #endregion
    }
}
