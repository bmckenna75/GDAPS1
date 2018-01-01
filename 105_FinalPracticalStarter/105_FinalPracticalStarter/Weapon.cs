using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**********************************
// Weapon class
// Inherits from Item
//**********************************

namespace _105_FinalPracticalStarter
{
    class Weapon : Item
    {
		// Fields
		private int durabilityCurrent;
		private int durabilityMaximum;
		private int damage;

		// Constructor
		public Weapon(String name, int durability, int damage, double weight)
			: base(name, weight)
		{
			this.durabilityCurrent = durability;
			this.durabilityMaximum = durability;
			this.damage = damage;
		}

		// Methods

		// Uses the weapon if possible, reducing its durability
		public override bool Use()
		{
			if (durabilityCurrent >= 1)
			{
				durabilityCurrent--;
				Console.WriteLine("You swing the " + name + ".");
				return true;
			}
			else
			{
				Console.WriteLine("You attempt to use the " + name + " but it is broken");
				return false;
			}
		}

		// Repairs the weapon back to its maximum durability
		public void Repair()
		{
			durabilityCurrent = durabilityMaximum;
			Console.WriteLine(name + " has been repaired to maximum durability");
		}

		// Returns a string representation of the weapon
		public override string ToString()
		{
			return
				base.ToString() +
				", which is a weapon with " +
				durabilityCurrent + "/" + durabilityMaximum + " uses left. " +
				"It deals " + damage + " damage.";
		}
	}
}
