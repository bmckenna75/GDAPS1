using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
	public abstract class BakedGood
	{
		//fields
		protected double price;
		public double Price
		{
			get { return price; }
		}
	

		//constructor
		public BakedGood()
		{
			price = 0;
		}

		//methods
		public abstract void PrintInformation();
	}
}
