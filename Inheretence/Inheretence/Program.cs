using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretence
{
    class Program
    {
        static void Main(string[] args)
        {
            PinkX PinkBox = new PinkX(7, 3, 5, 2.9, 4);
            Pinwheel PurpleToy = new Pinwheel(12, 2, 9, 4.6);
            GreenSquare GreenBox = new GreenSquare(11, 1, 3, 3.0, 4);
            BlueDIamond BlueBox = new BlueDIamond(10, 1, 2, 3.2, 2);

            Console.WriteLine("The enemy called PinkBox has " + PinkBox.Health + " and is a level " + PinkBox.Level + " enemy that splits into " + PinkBox.SplitsInto + " when it dies.");
            Console.WriteLine("The enemy called PurpleToy has " + PurpleToy.Health + " and is a level " + PurpleToy.Level + " enemy that goes in random directions.");
            Console.WriteLine("The enemy called GreenBox has " + GreenBox.Health + " and is a level " + GreenBox.Level + " enemy that retreats " + GreenBox.RetreatDistance + " units when it gets hit.");
            Console.WriteLine("The enemy called BlueBox has " + BlueBox.Health + " and is a level " + BlueBox.Level + " enemy that does " + BlueBox.ExtraDamage + " extra damage.");


        }
    }
}
