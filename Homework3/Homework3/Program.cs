using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
	class Program
	{
		static void Main(string[] args)
		{
			//introduction
			Console.WriteLine("Welcome to Artillery Golf!\nYour goal is to hit a target that is precisely 751 meters away.");
			Console.WriteLine();

			//assigning var names so I don't die to this later
			bool targetHit = false;
			double cannonAngle;
			double cannonForce;
			double angleRads;
			double funcPart;
			double time;
			double calcDist;

			for (int x = 0; x < 10; x++)
			{
				Console.WriteLine("Attempt " + (x + 1) + ": --------------------");

				//assigns cannon angle and force and loops until correct
				do
				{
					Console.WriteLine("Please enter the cannon's angle. (between 0 and 90)");
					cannonAngle = double.Parse(Console.ReadLine());
				}
				while (!(cannonAngle >= 0 && cannonAngle <= 90));

				do
				{
					Console.WriteLine("Please enter the cannon's strength. (Greater than or equal to 0)");
					cannonForce = double.Parse(Console.ReadLine());
				}
				while (!(cannonAngle >= 0));


				//calculation in chunks

				angleRads = cannonAngle * Math.PI / 180;
				//funcPart is the nearly unmanagable part near the middle seperated to make things easier
				funcPart = (Math.Pow((Math.Pow(cannonForce, 2) * Math.Pow(Math.Sin(angleRads), 2) + 20.0 * 2.0 * Math.Sin(angleRads)), .5));

				time = (cannonForce * Math.Sin(angleRads) + funcPart / 10.0);

				//final calculationn assigned to calcDist
				calcDist = cannonForce * Math.Cos(angleRads) * time;


				//check for hit

				if (calcDist >= 750.5 && calcDist <= 751.5)
				{
					targetHit = true;
					Console.WriteLine("Your ball landed " + (751 - calcDist) + " from the target!"); 
					break;
				}
				else
				{
					Console.WriteLine("Your ball landed " + (751 - calcDist) + " from the target!");
					Console.WriteLine("Try again!");
				}





			}
			if (targetHit == true)
			{
				Console.WriteLine("Congratulations! You Win!");
			}
			else
			{
				Console.WriteLine("You've run out of tries. Thanks for playing.");
			}

		}
	}
}
