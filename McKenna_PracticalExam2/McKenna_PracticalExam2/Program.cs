using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McKenna_PracticalExam2
{
    class Program
    {
        static void Main(string[] args)
        {
            //calls and gather names
            Console.WriteLine("Welcome to DICETOWER!\n\nPlease enter Player 1's name:");
            string name1 = Console.ReadLine();
            Console.WriteLine("\nPlease enter Player 2's name:");
            string name2 = Console.ReadLine();

            //round number and dice per round and which dice

            Console.WriteLine("\nWhat kind of dice would you like to roll today? (enter a number of sides)");
            int sides = int.Parse(Console.ReadLine());
            Console.WriteLine("\nHow many would you like to roll?");
            int numberRolled = int.Parse(Console.ReadLine());
            Console.WriteLine("\nHow many rounds would you like to play?");
            int rounds = int.Parse(Console.ReadLine());
            
            Player Player1 = new Player(name1);
            Player Player2 = new Player(name2);
            DiceTower Roller = new DiceTower();


            for (int i = 0; i < rounds; i++)
            {
                Console.WriteLine("Round " + (i + 1) + "-------------");
                Console.WriteLine("\nPlayer 1's turn");
                Player1.AddDiceToScore(Roller.GenerateDiceRolls(numberRolled, sides));
                Console.WriteLine("\nPlayer 2's turn");
                Player2.AddDiceToScore(Roller.GenerateDiceRolls(numberRolled, sides));
                
            }

            if (Player1.Score > Player2.Score)
            {
                Console.WriteLine("Congratulations, Player 1 Wins!");
            }
            else if (Player1.Score < Player2.Score)
            {
                Console.WriteLine("Congratulations, Player 2 Wins!");
            }
            else
            {
                Console.WriteLine("Congratulations, It's a tie!");
            }



        }
    }
}
