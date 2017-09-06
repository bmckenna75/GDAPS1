using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZCharMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: Zera Straxus");
            Console.WriteLine("Class: Wizard");
            Console.WriteLine();
            Console.WriteLine("Dex: " + 50 * .2);
            Console.WriteLine("Str: " + 50 * .2 * .5);
            Console.WriteLine("Int: 7");
            Console.WriteLine("Con: " + ((50 * .2 + 50 * .2 * .5) - 2));
            Console.WriteLine("Cha: " + (50 - (50 * .2 * .5) - (50 * .2) - 7 - ((50 * .2 + 50 * .2 * .5) - 2)));
            Console.WriteLine();
            Console.WriteLine("Total: 50");
        }
    }
}
