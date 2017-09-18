using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("What does Zera sense? ");
			string sensed = Console.ReadLine();
			sensed = sensed.Trim().ToLower();
			if (sensed == "bells")
			{
				Console.WriteLine("Zera walks over and rings one of the bells.");
			}
			else if (sensed == "door")
			{
				Console.WriteLine("Zera opens the door and peers inside.");
			}
			else if (sensed == "keyboard")
			{
				Console.WriteLine("Zera sits down and tests to see if the keyboard is mechanical.");
			}
			else if (sensed == "wallet")
			{
				Console.WriteLine("Zera sighs thankfully as he finally finds his wallet.");
			}
			else
			{
				Console.WriteLine("Zera looks confused.");
			}


		}
	}
}
