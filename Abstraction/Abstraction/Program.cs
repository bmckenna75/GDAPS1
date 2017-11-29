using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to dragon battle simulator 2034!");

			int round = 0;
			Random rng = new Random();

			FrostDrgn nora = new FrostDrgn("Nora", 100, rng);
			BlackDrgn reni = new BlackDrgn("Reni", 115, rng);

			Console.WriteLine(nora.ToString());
			Console.WriteLine(reni.ToString());


			do
			{
				round++;
				Console.WriteLine("Round " + round + ": -------------------------");
				reni.TakeDamage(nora.Attack());
				nora.TakeDamage(reni.Attack());

				Console.WriteLine(reni.Name + " has " + reni.Health + " hp left");
				Console.WriteLine(nora.Name + " has " + nora.Health + " hp left");
				System.Threading.Thread.Sleep(1000);
			}
			while (nora.IsDead() && reni.IsDead());

			if (nora.IsDead() && !reni.IsDead())
			{
				Console.WriteLine(nora.Name + " wins!");
			}
			else if (!nora.IsDead() && reni.IsDead())
			{
				Console.WriteLine(reni.Name + " wins!");
			}
			else
			{
				Console.WriteLine("Both contestants have been knocked out, it's a tie!");
			}
		}
	}
}
