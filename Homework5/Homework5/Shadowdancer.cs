using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Shadowdancer : CommonCharacter
    {
        //constructer

        protected bool stealth = false;
        protected bool highGround = true;

        public Shadowdancer(int h, int d, int s, int i, int aC, bool Stealth, bool hG, Random r)
        {
            health = h;
            dexterity = d;
            strength = s;
            intelegence = i;
            armorClass = aC;
            stealth = Stealth;
            highGround = hG;
            Roller = r;

        }



        public Shadowdancer()
        {
            health = 11;
            dexterity = 16;
            strength = 14;
            intelegence = 11;
            armorClass = 13;
            stealth = false;
            highGround = true;
            Roller = new Random();
        }



        public override string ToString()
        {
            return ("This Shadowdancer has a health of " + health + ", has a dex of " + dexterity + ", has a str of "
                + strength + ", has an int of " + intelegence + " and has an armor class of " + armorClass);
        }

        //generic methods
        public int Attack(int defenderAC)
        {
            if (Roller.Next(1,21) >= defenderAC && !highGround)
            {
                return Roller.Next(1,7);
            }
            else if (Roller.Next(1, 21) >= defenderAC && highGround)
            {
                return (Roller.Next(1,7) * 2);
            }
            else
            {
                return 0;
            }
        }

        public int TakeDamage(int Damage)
        {
            if (!stealth)
            {
                health = health - Damage;
            }
            else
            {
                if (Roller.Next(0, 10) >= 8)
                {
                    Console.WriteLine("The shadowdancer steps back and dodges the attack with extreme speed and grace.");
                }
                else
                {
                    health = health - Damage;
                    stealth = false;
                    highGround = false;
                }
            }
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

        //come back with your opponent's shield or on yours
        public bool HasFled()
        {
            return false;
        }


        //class methods
        //Where'd he go?
        public void Stealth()
        {
            stealth = true;
            Console.WriteLine("The shadowdancer steps back and vanishes into the darkness.");
        }
        //It's over archmage, I have the higher ground
        public void HighGround()
        {
            highGround = true;
            Console.WriteLine("The shadowdancer moves up the hill with suprising speed to gain an advantagious possition");
        }





    }
}
