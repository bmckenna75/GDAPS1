using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Cell
    {
		/*
         * Chris/Dom, I'm very sorry you're going to have to grade this because it's going to be a train wreck.
         * 
         * It will work though and that's what matters.
         */

		protected bool alive;
		public bool Alive
		{
			get { return alive; }
			set { alive = value; }
		}
        public Cell() { }

        
        public override string ToString()
        {
			if (alive == true)
			{
				return "#";
			}
			else
			{
				return "@";
			}
        }


    }
}
