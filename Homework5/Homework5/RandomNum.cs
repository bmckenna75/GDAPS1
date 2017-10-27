using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class RandomNum
    {
        Random rng = new Random();

        public RandomNum()
        {
            
        }

        //general rng
        public int TwentySided()
        {
            return rng.Next(1, 21);
        }
        public int Damage()
        {
            return rng.Next(1, 7);
        }

        //rogue class rng
        public bool UncannyDodge()
        {
            if (rng.Next(0,10) >= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
