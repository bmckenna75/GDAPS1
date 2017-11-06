using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Seb = new Player();
            bool switchOut = false;

            Seb.AddToInv("Sword of the Slipstream");
            Seb.AddToInv("Cloth Armor");
            Seb.AddToInv("Pouch of Sand");


            do
            {

                Console.WriteLine("What would you like to do?");

                string switchVar = Console.ReadLine().Trim().ToLower();

                switch (switchVar)
                {
                    case "print":
                        Console.WriteLine("The Player has: ");
                        Seb.PrintInv();
                        continue;

                    case "quit":
                        switchOut = true;
                        continue;

                    case "get":
                        Console.WriteLine("Please enter a number for where the item is in the inventory: ");
                        Console.WriteLine("Removed: " + Seb.GetItemInSlot(int.Parse(Console.ReadLine())));
                        continue;

                    default:
                        Seb.AddToInv(switchVar);
                        Console.WriteLine(switchVar + " has been added to inventory");
                        continue;
                }


            }
            while (switchOut == false);

        }
    }
}
