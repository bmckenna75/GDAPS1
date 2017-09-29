using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermanHomework
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Welcome to the Superman Jump Sim!\n\nYour target building is 660 feet high.\nPlease enter the gravitational constant for the planet you want.");

			//preventing problems
			bool loopAgain = false;
			double gravConst;
			double initVelo;
			string excapeString;


			{

				//get Gravitational Constant
				do
				{
					Console.Write("\n\nGravitational Constant: ");
					gravConst = double.Parse(Console.ReadLine());
				}
				while (!(gravConst > 0));

				//peform calculations

				initVelo = Math.Pow(2 * gravConst * 660, .5);

				Console.WriteLine("On a planet with a Gravitional Constant of " + gravConst + "ft/sec^2, Superman would have to have an initial" +
					" velocity of " + initVelo + "ft/sec to jump a 660 foot building.");

				//excape loop
				Console.WriteLine("Would you like to try again with different values? (y/N)");

				excapeString = Console.ReadLine().Trim().ToUpper();
				if (excapeString == "Y")
				{
					loopAgain = true;
				}
				else
				{
					loopAgain = false;
					Console.WriteLine("See you next time!");
				}
				


			}
			while (loopAgain);
		}
	}
}
