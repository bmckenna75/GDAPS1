using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSplit
{
	class Player
	{
		//fields
		protected string name;
		public string Name
		{
			get { return name; }
		}
		protected int strength;
		public int Strength
		{
			get { return strength; }
		}
		protected int health;
		public int Health
		{
			get { return health; }
		}

		//constructor
		/// <summary>
		/// Creates a new player named Bob with 30 str and 100 health
		/// </summary>
		public Player() : this("Bob", 30, 100) { }


		/// <summary>
		/// Creates a player with a defined Name, Strength and Health
		/// </summary>
		/// <param name="Name"></param>
		/// <param name="Strength"></param>
		/// <param name="Health"></param>
		public Player(string n, int s, int h)
		{
			name = n;
			strength = s;
			health = h;
		}

		//methods
		public override string ToString()
		{
			return ("The player, " + name + " has a strength of " + strength + " and has " + health + " health points");
		}

	}
}
