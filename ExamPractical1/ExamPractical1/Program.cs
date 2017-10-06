using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPractical1
{
	class Program
	{
		static void Main(string[] args)
		{
			//initialization of var
			int goldCurrent = 0;
			bool badGoldAttempt = false;

			Console.WriteLine("Hello Adventurer!\n\n What is your name?\n");
			string name = Console.ReadLine().Trim().ToUpper();
			Console.WriteLine("\nWhy hello " + name + " it's good to meet you.\n\nHow much gold do you have on you right now?");

			do
			{
				if (badGoldAttempt == true)
				{
					Console.WriteLine("Surely you must be richer than that, I'd wager you have at least 100 gold on you right now.");
				}
				else
				{
					//encountered a logic error that is solved by having these brackets here
				}

				goldCurrent = int.Parse(Console.ReadLine());
				badGoldAttempt = true;
			}
			while (!(goldCurrent >= 100));


			//First item purchace
			Console.WriteLine("Since you're going on a quest, you'll need a weapon. " +
				"I recommend an iron broadsword, it's the iron standard for cutting things!");
			Console.WriteLine("\nYou buy the iron broadsword.\n\nYou now have " + 
				(goldCurrent / 2) + " remaining gold pieces.");
			goldCurrent = goldCurrent / 2;

			//Second Item Purchase
			Console.WriteLine("If you get into trouble out in the middle of nowhere, you'll " +
				"need some way to heal up. This potion will restore you to your full strength.");
			Console.WriteLine("\nYou buy the potion.\n\nYou now have " + 
				(goldCurrent - (goldCurrent/4)) + " remaining gold pieces");
			goldCurrent = goldCurrent - (goldCurrent / 4);

			//Third item purchase
			if (goldCurrent >= 375)
			{
				Console.WriteLine("I see you still have a lot of extra gold so let me show you one of our most powerful items,\n\nTHE TOME OF THE ANCIENTS\n\n" +
					"This powerful artifact can demolish your enemies in one word and today it's only 375 gold pieces!");
				Console.WriteLine("\nYou buy the TOME OF THE ANCIENTS.\n\nYou now have " +
				(goldCurrent - 375) + " remaining gold pieces");
				goldCurrent = goldCurrent - 375;
			}
			else
			{
				Console.WriteLine("If you had more money, I could offer you this Tome of the Ancient " +
					"Ones, but it looks like the price is too high for you right now.");
			}

			//end scenarios
			Console.WriteLine("Thanks for shopping at Lei's Armory and Library!");
			if (goldCurrent > 0)
			{
				Console.WriteLine("You managed to excape shopping with " + goldCurrent + " gold pieces remaining, Good Job!");
			}
			else
			{
				Console.WriteLine("That shopkeeper took you for everything you had, you have no gold remaining.");
			}

		}
	}
}
