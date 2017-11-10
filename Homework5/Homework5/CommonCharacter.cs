using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class CommonCharacter
    {
        protected string name;
        protected int health;
        protected int dexterity;
        protected int strength;
        protected int intelegence;
        protected int armorClass;
        protected Random Roller = new Random();
        public int Health
        {
            get { return health; }
        }
        public int Dexterity
        {
            get { return dexterity; }
        }
        public int Strength
        {
            get { return strength; }
        }
        public int Intelegence
        {
            get { return intelegence; }
        }
        public int ArmorClass
        {
            get { return armorClass; }
        }
        public string Name
        {
            get { return name; }
        }

        public CommonCharacter(string n, int h, int d, int s, int i, int AC)
        {
            name = n;
            health = h;
            dexterity = d;
            strength = s;
            intelegence = i;
            armorClass = AC;
            Random Roller = new Random();
        }
        public CommonCharacter() : this("Bob", 100, 10, 10, 10, 10) { }



        //methods 
        //does not need to be overridden
        public bool IsDead()
        {
            if (health <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //is overridden
        public virtual bool HasFled()
        {
            if (health < 50) { return true; }
            return false;
        }

        public virtual int TakeDamage(int Damage)
        {
            health = health - Damage;
            return health;
        }

        public virtual int Attack(int defenderAC)
        {
            if (Roller.Next(1, 21) >= defenderAC)
            {
                return Roller.Next(1, 6);
            }
            else
            {
                return 0;
            }
        }


    }
}
