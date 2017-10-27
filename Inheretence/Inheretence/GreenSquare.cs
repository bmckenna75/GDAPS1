using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence
{
    class GreenSquare : Enemy
    {

        private int retreatDistance;

       public int RetreatDistance
        {
            get { return retreatDistance; }
        }


  


        public GreenSquare(int h, int l, int d, double s, int r)
        {
            health = h;
            level = l;
            color = "Green";
            type = "Square";
            damage = d;
            speed = s;
            retreatDistance = r;
        }


    }
}
