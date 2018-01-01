using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
	class FrostDrgn : Drgn
	{
		public FrostDrgn(string n, int h, Random r) : base(n, h, r)
		{

		}
		public override int Attack()
		{
			int damage = 0;
			damage = rng.Next(5, 26);
			Console.WriteLine(name + " does " + damage + " points of damage");
			return damage;
		}
		public override int TakeDamage(int d)
		{
			health -= d;
			return health;
		}
		public override string ToString()
		{
			return name + " has " + health + " and freezes foes";
		}
	}
}
