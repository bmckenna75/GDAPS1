using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Archmage : CommonCharacter
    {
        private bool focus = true;
        private int chargeLevel = 0;
        //constructer
        public Archmage(Random r)
        {
            health = 10;
            dexterity = 13;
            strength = 8;
            intelegence = 17;
            armorClass = 14;
            chargeLevel = 0;
            focus = true;
            Roller = r;
        }

        public override string ToString()
        {
            return ("This Archmage has a health of " + health + ", has a dex of " + dexterity + ", has a str of "
                + strength + ", has an int of " + intelegence + " and has an armor class of " + armorClass);
        }

        //generic methods
        public int Attack(int defenderAC)
        {
            chargeLevel++;
            if (Roller.Next(1,21) >= defenderAC)
            {
                return Roller.Next(1,7);
            }
            else
            {
                return 0;
            }
        }

        public int TakeDamage(int Damage)
        {
            health = health - Damage;
            focus = false;
            return health;
        }

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
        //the archmage shall not show fear before his lessers
        public bool HasFled()
        {
            return false;
        }

        //class methods
        //endgame insurance for archmage
        public int ChargeShot()
        {
            if (chargeLevel > 4)
            {
                int damage = 0;
                for (int i = 0; i < 40; i++)
                {
                    damage += Roller.Damage();
                }
                return damage;
            }
            else { return 0; }
        }
        //focus for bonus damage
        public void Focus()
        {
            focus = true;
        }



    }
}
