using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//**********************************
// Item class
// Abstract
// Change NOTHING in this file
//**********************************

namespace _105_FinalPracticalStarter
{
    abstract class Item
    {
        // Fields
        protected String name;
        protected double weight;

        // Properties
        public String Name { get { return name; } }
        public double Weight { get { return weight; } }

        // Constructor
        public Item(String name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }

        // Methods
        public abstract bool Use();

		// Returns a string representation of the item
		public override string ToString()
        {
            return "This is an item named '" + name + "' and weighs " + weight + " pounds";
        }
    }
}
