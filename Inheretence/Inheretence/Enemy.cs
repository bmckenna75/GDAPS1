using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence
{
    class Enemy
    {

        protected int health = 10;
        protected int level = 1;
        protected string color;
        protected string type = "default" ;
        protected int damage = 4;
        protected double speed = 3.5;
        protected string role = "enemy";

        public int Health
        {
            get { return health; }
        }
        public int Level
        {
            get { return level; }
        }
        public int Damage
        {
            get { return damage; }
        }


    }
}
