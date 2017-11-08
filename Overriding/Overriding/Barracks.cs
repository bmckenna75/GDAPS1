using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class Barracks
    {
        //fields
        Random Roller;
        //constructor
        public Barracks()
        {
            Roller = new Random();
        }
        //methods
        public RPGChar SpawnChar(string n, int s, int d, int i)
        {
            RPGChar Char;
            int number = Roller.Next(1, 101);
            if (number <= 60)
            {
                Char = new Warrior();                
            }
            else if (60 < number && number <= 90)
            {
                Char = new Wizard();                
            }
            else
            {
                Char = new Rogue();                
            }
            return Char;
        }





    }
}
