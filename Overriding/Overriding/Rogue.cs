using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class Rogue : RPGChar
    {
        protected int cellPhoneRings;
        public int CellPhoneRings
        {
            get { return cellPhoneRings; }
            set { cellPhoneRings = value; }
        }

        bool phoneSmash = false;

        //constructor
        public Rogue() : this("Carmen", 13, 15, 10, 0)
        {

        }
        public Rogue(string n, int s, int d, int i, int cPR) : base(n, s, d, i)
        {
            cellPhoneRings = cPR;
        }

        //general things
        public override string ToString()
        {
            return (base.ToString() + "has had their phone ring " + cellPhoneRings + " times while in the middle of a heist\n");
        }
        
        public void SmashPhone()
        {
            //Carmen smash
            phoneSmash = true;
            
        }

        public override void GainXP(int exp)
        {
            base.GainXP(exp);
            if ((xp-(level*200))/200 < 1)
            {
                if (dexterity < 20)
                {
                    dexterity++;
                }
            }
        } 

        public void Heist()
        {
            if (!phoneSmash)
            {
                if (rng.Next(1,xp) <= 10)
                {
                    cellPhoneRings++;
                    //drat, I need to take this
                }
            }
        }





    }
}
