using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence
{
    class Pinwheel : Enemy
    {

        private Random directionFinder = new Random();

        private int direction;

        public int Direction
        {
            get { return direction; }
        }

  




        public Pinwheel(int h, int l, int d, double s)
        {
            health = h;
            level = l;
            color = "Purple";
            type = "Pinwheel";
            damage = d;
            speed = s;
            direction = directionFinder.Next(0,360);
        }

    }
}
