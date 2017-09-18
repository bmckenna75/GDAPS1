using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingExersize
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter a number with a decimal point");
			string numberString = Console.ReadLine();
			decimal number = decimal.Parse(numberString);

			string numberMoney = number.ToString("C");
			string numberPercent = number.ToString("P");
			int numberInt = (int)number; //Jank Code(tm) to make the program not crash on 20 via typecasting
			string numberIntText = numberInt.ToString();

			Console.WriteLine("{0} is a good number, thanks.", number);
			Console.WriteLine("If your number was a price, it would be formatted like {0}", numberMoney);
			Console.WriteLine("If your number was a percentage, it would be formatted like {0}", numberPercent);
			Console.WriteLine("If your number was an integer, it would be formatted like {0}", numberIntText);
			Console.WriteLine();

			string numString = String.Format("Again, {0} as a price is {0:C},\n as a percentage is {0:P}\n and as an int is {0:F0}.", number);
			Console.WriteLine(numString);
			Console.WriteLine();
			Console.WriteLine("{0}", number);
			Console.WriteLine("{0:C}", number);
			Console.WriteLine("{0:P}", number);
			Console.WriteLine("{0:F0}", number);
		}

	}
}
