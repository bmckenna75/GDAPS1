using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2TextBasedRPG
{
	class Program
	{
		static void Main(string[] args)
		{
			// Predefining variables for the story
			bool sandbagger = true;
			bool corrupted = true;

			//Act 1
			Console.WriteLine("As you turn the corner into the next room, you " +
				"are caught off guard and stare in awe!");
			Console.WriteLine("You are standing in front of something you have dreamed " +
				"of for so long, the Staff of the Magi.\n");
			Console.WriteLine("As you approach the staff, you see that it is perfectly weighted" +
				" on a pressure sensitive pedistle. \n\n\nIf you take it, it will almost assuradly trigger a trap.\n");
			Console.WriteLine("At this point you can either take the staff and RUN or try" +
				" to use a SANDBAG to even out the weight.");
			//Choice 1

			string act1Choice = Console.ReadLine().Trim().ToUpper();

			if (act1Choice == "SANDBAG")
			{
				sandbagger = true;
			}
			else if (act1Choice == "RUN")
			{
				sandbagger = false;
			}
			else
			{
				Console.WriteLine("You choose to not choose and starve to death while trying to decide.\n\nGame Over");
				System.Environment.Exit(0);
			}
			//Act 2
			Console.WriteLine("As you grab the staff, the plate begins to rise, drat. " +
				"\nYou quickly turn and run as fast as possible to the entrence.");
			Console.WriteLine("You nearly get crushed by a rolling bolder " +
				"but you make it out of the dungeon alive.");
			Console.WriteLine("Now comes the hard question: What are you going to do with the staff?\n\n");
			Console.WriteLine("Are you going to SELL it or are you going to USE it to \"extract\" some extra money.");

			string act2Changer = Console.ReadLine().Trim().ToUpper();


			if (act2Changer == "SELL")
			{
				corrupted = false;
			}
			else if (act2Changer == "USE")
			{
				corrupted = true;
			}
			else
			{
				Console.WriteLine("Your conscious apathy to anything kills you.\n\nGame Over");
				System.Environment.Exit(0);
			}

			//Act 3
			if (sandbagger == true && corrupted == true)
			{
				Console.WriteLine("After such are smart attempt to outsmart a trap earlier, " +
					"you immediatly use the staff without checking it for curses.\n\nYou are now possessed. Game Over");
			}
			else if (sandbagger == true && corrupted == false)
			{
				Console.WriteLine("You are doing very well today, first you narrowly avoid a " +
					"boulder then you realize the staff you swiped is cursed. \nYou sell the staff and get a nice fee.\n\n Good job avoiding that. You Win");
			}
			else if (sandbagger == false && corrupted == true)
			{
				Console.WriteLine("First you set off the boulder trap and then you " +
					"get possessed by a spirit in the staff you stole.\n\nToday is just not your day. Game Over");
			}
			else if (sandbagger == false && corrupted == false)
			{
				Console.WriteLine("You may have messed up with the boulder trap but " +
					"you immediatly see that the staff is cursed.\n\n You sell the staff immediatly. You Win");
			}
			else
			{
				Console.WriteLine("If you manage to get this ending, then please tell me how");
			}

		}
	}
}
