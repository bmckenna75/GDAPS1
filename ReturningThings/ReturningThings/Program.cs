using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturningThings
{
	class Program
	{
		static void Main(string[] args)
		{
			string whatToDo;
			int excape = 0;
			Book TheHobbit = new Book("The Hobbit", "J. R. R. Tolkien", 312);



			do
			{
				Console.WriteLine("What would you like to do today? (read/report/time/quit)");
				whatToDo = Console.ReadLine().Trim().ToLower();

				switch (whatToDo)
				{
					case "read":
						Console.WriteLine("How many pages do you want to read?");
						TheHobbit.ReadPages(int.Parse(Console.ReadLine()));
						break;
					case "report":
						Console.WriteLine(TheHobbit.BookReport());
						break;
					case "time":
						Console.WriteLine("Please enter the time it takes for you to read one page.");
						Console.WriteLine("It will take you " + 
							TheHobbit.TimeToFinishReading(double.Parse(Console.ReadLine())) 
							+ " minutes to finish the book");
						break;
					case "quit":
						excape = 1;
						break;


				}
			}
			while (excape != 1);
		}
	}
}
