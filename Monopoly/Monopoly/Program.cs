using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
	class Program
	{
		static void Main(string[] args)
		{
            //constructs roller object
            Dice Roller = new Dice();


            //tests die
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(Roller.RollDie());
            }


            //monopoly objects
            Monopoly game = new Monopoly();


            //analizes and prints

            double[] results = game.Analyze();

            game.PrintResults(results);





		}
	}
}


