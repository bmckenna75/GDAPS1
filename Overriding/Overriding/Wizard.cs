using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class Wizard : RPGChar
    {

        protected double hotPocketPercent;
        public double HotPocketPercent
        {
            get { return hotPocketPercent; }
            set { hotPocketPercent = value; }
        }



        //constructor
        public Wizard() : this("Gandalf", 13, 15, 10, 45.7)
        {

        }
        public Wizard(string n, int s, int d, int i, double hPP) : base(n, s, d, i)
        {
            hotPocketPercent = hPP;
        }

        //general things
        public override string ToString()
        {
            return (base.ToString() + "has a " + hotPocketPercent + "% chance to cast a Hot Pocket instead of being useful\n");
        }

        public override void GainXP(int exp)
        {
            base.GainXP(exp);
            if ((xp - (level * 200)) / 200 < 1)
            {
                if (intelligence < 20)
                {
                    intelligence++;
                    hotPocketPercent -= 10.3;
                }
            }
        }
    }
}
