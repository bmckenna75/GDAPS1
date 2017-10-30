using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {

            Random Roller = new Random();
            Archmage Robin = new Archmage(10, 13, 8, 17, 14, 0, true, Roller);
            Shadowdancer Lei = new Shadowdancer(11, 16, 14, 11, 13, false, true, Roller);


        }

    }


}



