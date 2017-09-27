using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchesandLogic
{
	class Program
	{
		static void Main(string[] args)
		{
			int act1Choice;
			int act2Choice;
			//Ask user for their choice
			Console.WriteLine("You are walking through a dimly lit dungeon when you come across a chamber with two doors.");
			Console.WriteLine("As you walk closer, you see one door is marked with a star and one is marked with a moon.");
			Console.WriteLine("Which door do you enter?");
			Console.WriteLine();
			Console.WriteLine(" 1: Star\n 2: Moon");

			act1Choice = -1;
			while (!(act1Choice == 1 || act1Choice == 2))
			{
				act1Choice = int.Parse(Console.ReadLine());

				if (!(act1Choice == 1 || act1Choice == 2))
				{
					Console.WriteLine("That's not a door!");
				}
			}

			if (act1Choice == 1 || act1Choice == 2)
			{
				Console.WriteLine("As you pass through the door you see that there is a huge pile of gold in front of you.");
				Console.WriteLine("A sign in fron to the pile reads \"Those who steal from Thranos shall be punished.\"");
				Console.WriteLine("Do you take the gold?");
				Console.WriteLine();
				Console.WriteLine(" 1: Yes\n 2: No");

				do
				{
					act2Choice = int.Parse(Console.ReadLine().Trim());
					if (!(act2Choice == 2 || act2Choice == 1))
					{
						Console.WriteLine("That doesn't answer the question");
					}
				}
				while (!(act2Choice == 2 || act2Choice == 1));
					switch (act2Choice)
				{
					case 1:
						Console.WriteLine("You take the gold without even a second though.\nHopefully it won't end up killing you...");
						break;
					case 2:
						Console.WriteLine("You respect the threat. Thranos is not a god to be trifled with.");
						break;
					default:
						Console.WriteLine("You stare at the gold hungrily. Eventually you actually get hungry and die.\nGame Over ");
						System.Environment.Exit(0);
						break;
				}
				if (act1Choice == 1 && act2Choice == 1)
				{
					Console.WriteLine("It seems you made the right choice to steal Thranos' gold as you live with no issues.\nYou Win");
				}
				else if (act1Choice == 1 && act2Choice == 2)
				{
					Console.WriteLine("Staying on the side of caution may have saved your life as you progress through the dungeon with no gold.\nYou Win");
				}
				else if (act1Choice == 2 && act2Choice == 1)
				{
					Console.WriteLine("As you reach to take the gold, you set off a tripwire that triggers crossbows hidden in the wall, killing you instantly\n Game Over" +
						" Don't mess with Thranos' gold.");
				}
				else if (act1Choice == 2 && act2Choice == 2)
				{
					Console.WriteLine("As you pass by the gold, you see a tripwire that would have surely caused your death if you tried to steal the gold. Good thing you didn't.\nYou Win");
				}
			}
			else
			{
				Console.WriteLine("You stare at the doors in indecision and eventually starve to death.\nGame Over");
			}

		}
	}
}
