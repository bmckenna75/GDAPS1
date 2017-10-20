using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
	class Dice
	{

		private Random rng;

		public Dice()
		{
			rng = new Random();
		}

		//Roll Tide! Roll Tide!
		public int RollDie()
		{
			return rng.Next(1, 7);
		}


		public int RollDice(int n)
		{
			int rollTotal = 0;
			for (int i = 0; i < n; i++)
				{
				rollTotal = rollTotal + RollDie();
				}
			return rollTotal;
		}	


	}
}
