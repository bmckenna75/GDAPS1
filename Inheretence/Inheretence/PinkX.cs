using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence
{
    class PinkX : Enemy
    {
        private int splitsInto;

        public int SplitsInto
        {
            get { return splitsInto; }
        }




        public PinkX(int h, int l, int d, double s, int i)
        {
            health = h;
            level = l;
            color = "Pink";
            type = "PinkX";
            damage = d;
            speed = s;
            splitsInto = i;
        }


    }
}
