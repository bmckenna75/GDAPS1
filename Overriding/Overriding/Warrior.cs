using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class Warrior : RPGChar
    {

        protected int daysWithoutBath;
        public int DaysWithoutBath
        {
            get { return daysWithoutBath; }
            set { daysWithoutBath = value; }
        }



        //constructor
        public Warrior() : this("Drogo", 13, 15, 10, 2)
        {

        }
        public Warrior(string n, int s, int d, int i, int dWB) : base(n, s, d, i)
        {
            daysWithoutBath = dWB;
        }

        //general things
        public override string ToString()
        {
            return (base.ToString() + "has not taken a bath in " + daysWithoutBath + " days\n");
        }

        public override void GainXP(int exp)
        {
            base.GainXP(exp);
            if ((xp - (level * 200)) / 200 < 1)
            {
                if (strength < 20)
                {
                    strength++;
                    daysWithoutBath++;
                }
            }
        }

        public void TakeBath()
        {
            daysWithoutBath = 0;
        }
    }
}
