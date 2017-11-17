using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSplit
{
	class Program
	{
		static void Main(string[] args)
		{
			PlayerManager Control = new PlayerManager();
			bool exitVar = true;
			while (exitVar == true)
			{
				Console.Write("Choose one of the following options: \nCreate.Print.Save.Load.Quit. \n>>");
				string switcher = Console.ReadLine().Trim().ToLower();
				if (switcher == "create")
				{
					Console.WriteLine("Please enter: ");
					Console.Write("  Name: ");
					string name = Console.ReadLine();
					Console.Write("  Strength: ");
					int str = int.Parse(Console.ReadLine());
					Console.Write("  Health: ");
					int health = int.Parse(Console.ReadLine());
				}
				else if (switcher == "print")
				{
					Control.Print();
				}
				else if (switcher == "save")
				{
					Control.Save();
				}
				else if (switcher == "load")
				{
					Control.Load();
				}
				else if(switcher == "quit")
				{
					System.Environment.Exit(0);
				}
				else
				{
					Console.WriteLine("That's not a valid input please try again");
				}
			}

		}
	}
}
