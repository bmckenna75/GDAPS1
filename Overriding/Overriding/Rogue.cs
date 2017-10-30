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

        //constructor
        public Rogue() : this("Carmen", 13, 15, 10, 0)
        {

        }
        public Rogue(string n, int s, int d, int i, int cPR) : base(n, s, d, i)
        {
            cellPhoneRings = cPR;
        }


        public override string ToString()
        {
            return (base.ToString() + "has had their phone ring " + cellPhoneRings + " times while in the middle of a heist");
        }






    }
}
