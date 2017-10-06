using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNGandTryParse
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rng = new Random();
			int playerNum = -1;
			int targetNum = rng.Next(0, 101);
			bool swapOut = false;

			for (int i = 0; i < 8; i++)
			{
				swapOut = false;
				while (swapOut == false)
				{
					Console.Write("Try " + (i + 1) + ": Enter a number between 0 and 100: ");

					//janky yet effective way to check if it's a valid input
					if (int.TryParse(Console.ReadLine(), out playerNum)) 
					{
						if (playerNum <= 100 && playerNum >= 0)
						{
							swapOut = true; //excapes the 2nd layer of while loop to progress the program
						}
						else
						{
							Console.WriteLine("That's not a valid number");
						}
					}
					else
					{
						Console.WriteLine("That's not a valid number");
					}
				}
				
				//checks the number against the randomly generated one
				if (playerNum < targetNum)
				{
					Console.WriteLine("Your guess was lower than the target.");
				}
				else if (playerNum > targetNum)
				{
					Console.WriteLine("Your guess was higher than the target");
				}
				else
				{
					Console.WriteLine("Congratulations! You guessed " + targetNum);
					Console.WriteLine("Thanks for playing!");
					System.Environment.Exit(0);
				}

			

			}
			Console.WriteLine("Sorry, you used up all your guesses!\n\nThe target number was " + targetNum);
			Console.WriteLine("Game Over!");
		}
	}
}
