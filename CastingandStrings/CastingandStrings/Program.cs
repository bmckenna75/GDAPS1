using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingandStrings
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Hello, I will be analizing your name. \n Please enter your name:");
			string name = Console.ReadLine();
			Console.WriteLine();
			Console.WriteLine("Your name in Caps is: " + name.ToUpper());
			Console.WriteLine("The first letter of your name is: " + name[0]);
			Console.WriteLine("The last letter of your name is: " + name[(name.Length - 1)]); // Finds the length of the string then subtracts one and prints that char because arrays start at 0
			Console.WriteLine("Your name is " + name.Length + " letters long");
			Console.WriteLine();
			Console.WriteLine();


			//begining of price
			Console.WriteLine("We will now inspect a price. \n Please enter a price.");
			string priceText = Console.ReadLine();
			double price = double.Parse(priceText);
			Console.WriteLine();
			Console.WriteLine("The price you chose was $" + price);
			Console.WriteLine("The price with tax is $" + Math.Round((price + price * .08), 2));
			int priceInt = (int)price;
			Console.WriteLine("It costs $" + priceInt + " to buy this item");
			Console.WriteLine("It costs " + ((price - (double)priceInt) * 100) + " cents to purchase this item");

			//Janky number conversion to int and then comparason
			Console.WriteLine("Please enter a number: ");
			string numTextFirst = Console.ReadLine();
			int numFirst = int.Parse(numTextFirst);
			Console.WriteLine("Please enter another number: ");
			string numTextSecond = Console.ReadLine();
			int numSecond = int.Parse(numTextSecond);

			//comparason
			int max = Math.Max(numFirst, numSecond);
			Console.WriteLine("The larger number is: " + max);
		}
	}
}
