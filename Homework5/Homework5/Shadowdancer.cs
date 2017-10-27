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
        public Shadowdancer()
        {
            health = 11;
            dexterity = 16;
            strength = 14;
            intelegence = 11;
            armorClass = 13;
            stealth = false;
            highGround = true;
        }



        public override string ToString()
        {
            return ("This Shadowdancer has a health of " + health + ", has a dex of " + dexterity + ", has a str of "
                + strength + ", has an int of " + intelegence + " and has an armor class of " + armorClass);
        }

        //generic methods
        public int Attack(int defenderAC)
        {
            if (Roller.TwentySided() >= defenderAC && !highGround)
            {
                return Roller.Damage();
            }
            else if (Roller.TwentySided() >= defenderAC && highGround)
            {
                return (Roller.Damage() * 2);
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
                if (Roller.UncannyDodge() == true)
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
