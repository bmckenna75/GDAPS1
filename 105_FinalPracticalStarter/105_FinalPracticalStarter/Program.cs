using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**********************************************************
// README
// Do not 
// add to,
// remove,
// or change 
// any of 
// the code 
// below!
//
// Your code should work with the Main method as it is written.
//**********************************************************

namespace _105_FinalPracticalStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Create the inventory
            Inventory myPack = new Inventory();
            myPack.ReadData("inventoryItems.txt");
            Console.WriteLine("-----------------------------------");


            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Display all items in inventory
            myPack.PrintAllItems();
            Console.WriteLine("-----------------------------------");


            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Get the first item and use it
            Item first = myPack.GetFirstItem();
            if (first != null)
            {
                first.Use();
                Console.WriteLine(first);  
            }
            Console.WriteLine("-----------------------------------");


            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Search for a specific item and use it
            Item pie = myPack.Search("pie");
            if (pie != null)
            {
                pie.Use();
            }
            Console.WriteLine("-----------------------------------");


            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Get a specific weapon and use it until it can't be used anymore
            Item weapon = myPack.Search("Sword of Hitting");

            while (weapon != null && weapon.Use())
            {
                Console.WriteLine(weapon);
                Console.WriteLine("-----");
            }
            Console.WriteLine("-----------------------------------");


            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Repair all weapons 
            myPack.RepairAllWeapons();
            Console.WriteLine("-----------------------------------");


            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Display only weapons
            myPack.PrintAllWeapons();
        }
    }
}
