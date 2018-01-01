using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**********************************
// Food class
// Inherits from Item
//**********************************

namespace _105_FinalPracticalStarter
{
    class Food : Item
    {
		// Fields
		private int servings;

		// Constructor
		public Food(String name, int initialServings, double weight)
			: base(name, weight)
		{
			this.servings = initialServings;
		}

		// Methods

		// Uses the food if possible, reducing the number of servings left
		public override bool Use()
		{
			if (servings >= 1)
			{
				servings--;
				Console.WriteLine("You take a bite of the " + name + ". There are now " + servings + " servings remaining.");
				return true;
			}
			else
			{
				Console.WriteLine("You attempt to eat the " + name + " but there are no servings left");
				return false;
			}
		}

		// Returns a string representation of the food
		public override string ToString()
		{
			return
				base.ToString() +
				", which is food with " +
				servings + " servings left";
		}
	}
}
