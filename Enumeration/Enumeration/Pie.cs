using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
	class Pie : BakedGood
	{
		//field
		protected string filling;

		//constructor
		public Pie(string fill)
		{
			price = 8;
			filling = fill;
		}

		//methods
		public override void PrintInformation()
		{
			Console.WriteLine("\n---Pie Order---\n" + filling + " pie\nTotal: " + price);
		}
	}
}
