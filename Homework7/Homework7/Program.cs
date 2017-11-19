using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            Game Board = new Game();

            bool switchOff = false;
            while (switchOff == false)
            {
                Console.WriteLine("Welcome to the Game of Life!\n\nOptions:\n1 - Generate a new board\n2 - Display Board\n3 - Quit");
                string swapper = Console.ReadLine().Trim().ToLower();
                if (swapper == "1" || swapper == "generate")
                {
                    Console.WriteLine("Generating a new board");
                    Board.Generate();
                }
                else if (swapper == "2" || swapper == "display")
                {
                    Console.WriteLine("Displaying the current board.");
                    Board.Print();
                }
                else if (swapper == "3" || swapper == "quit")
                {
                    Console.WriteLine("Exiting...");
                    switchOff = true;
                }
                else
                {
                    Console.WriteLine("That's not a valid input, please try again");
                }


            }
            
             

        }
    }
}
