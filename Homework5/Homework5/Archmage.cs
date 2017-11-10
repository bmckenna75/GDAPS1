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
        public int ChargeLevel
        {
            get { return chargeLevel; }
        }
        //constructer


        public Archmage(string n, int h, int d, int s, int i, int aC, int cL, bool f) : base(n, h, d, s, i, aC)
        {
            name = n;
            health = h;
            dexterity = d;
            strength = s;
            intelegence = i;
            armorClass = aC;
            chargeLevel = cL;
            focus = f;
            //Random Roller = new Random();

        }

        public Archmage() : this("Lei", 10, 13, 8, 14, 0, 0, true)
        {

        }

        public override string ToString()
        {
            return ("This Archmage has a health of " + health + ", has a dex of " + dexterity + ", has a str of "
                + strength + ", has an int of " + intelegence + " and has an armor class of " + armorClass + "\nHis focus is " +focus + " and has a charge level of " + chargeLevel );
        }

        //generic methods
        public override int Attack(int defenderAC)
        {
            chargeLevel++;
            if (Roller.Next(1,21) >= defenderAC)
            {
                if (focus== true)
                {
                    return Roller.Next(1, 13);
                }
                return Roller.Next(1,7);
            }
            else
            {
                return 0;
            }
        }

        public override int TakeDamage(int Damage)
        {
            health = health - Damage;
            if (Damage != 0)
            {
                focus = false;
            }
            return health;
        }

        //the archmage shall not show fear before his lessers
        public override bool HasFled()
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
                    damage += Roller.Next(1,7);
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
