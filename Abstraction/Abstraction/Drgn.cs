using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
	public abstract class Drgn
	{
		protected Random rng;
		protected string name;
		public string Name
		{
			get { return name; }
		}
		protected int health;
		public int Health
		{
			get { return health; }
			set { health = value; }
		}

		public abstract int Attack();
		public abstract int TakeDamage(int d);

		public Drgn()
		{

		}
		public Drgn(string n, int h, Random r)
		{
			name = n;
			health = h;
			rng = r;
		}



		public bool IsDead()
		{
			bool alive = true;
			if (health <= 0)
			{
				alive = false;
			}

			return alive;
		}





	}
}
