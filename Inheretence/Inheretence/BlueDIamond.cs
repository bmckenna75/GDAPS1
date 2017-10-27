using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence
{
    class BlueDIamond : Enemy
    {

        private int extraDamage;

        public int ExtraDamage
        {
            get { return extraDamage; }
        }




        public BlueDIamond(int h, int l, int d, double s, int e)
        {
            health = h;
            level = l;
            color = "Blue";
            type = "Diamond";
            damage = d;
            speed = s;
            extraDamage = e;
        }
    }
}
