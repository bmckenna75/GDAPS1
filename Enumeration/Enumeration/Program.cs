using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
	enum DessertType
	{
		cake,
		pie
	}
	class Program
	{
		static void Main(string[] args)
		{
			Bakery Baker = new Bakery();
			bool exit = false;
			List<BakedGood> Order = new List<BakedGood>();
			do
			{
				Console.WriteLine("Welcome to the bakery, how can I help you?\n1 - Order a Cake or Pie\n2 - Remove a Cake or Pie\n3 - Display Order\n4 - Total\n'Exit' - Exit the Bakery");
				string switcher = Console.ReadLine().Trim().ToLower();
				if (switcher == "1")
				{
					Console.WriteLine("Do you want a cake or pie? (C/P)");
					string cakeOrPie = Console.ReadLine().Trim().ToLower();
					if ( cakeOrPie == "c")
					{
						Order.Add(Baker.Bake(DessertType.cake));
					}
					else if (cakeOrPie == "p")
					{
						Order.Add(Baker.Bake(DessertType.pie));
					}
					else
					{
						Console.WriteLine("That's not a valid input, try again");
					}
				}
				else if (switcher == "2")
				{
					Console.WriteLine("Please enter the number of the product you would like to put back: ");
					int index = int.Parse(Console.ReadLine().Trim());
					try
					{
						Order.RemoveAt(index-1);
					}
					catch
					{
						Console.WriteLine("That's outside of the range");
					}
				}
				else if (switcher == "3")
				{
					int i = 1;
					foreach (BakedGood dessert in Order)
					{
						Console.Write(i + ":");
						dessert.PrintInformation();
					}
				}
				else if (switcher == "4")
				{
					double total = 0;
					foreach (BakedGood dessert in Order)
					{
						total += dessert.Price;
					}
					Console.WriteLine("$" + total + " is your total right now.");
				}
				else if (switcher == "exit")
				{
					exit = true;
					continue;
				}
				else
				{
					Console.WriteLine("That's not a valid input, try again");
				}

			}
			while (exit == false);
		}
	}
}
