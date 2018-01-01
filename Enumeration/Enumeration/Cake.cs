using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
	class Cake : BakedGood
	{
		//fields
		protected string flavor;
		protected string frosting;
		protected int layers;

		//constructor
		public Cake(string flav, string frost, int lay)
		{
			flavor = flav;
			frosting = frost;
			layers = lay;
			price = 10 + (layers);
		}

		//methods
		public override void PrintInformation()
		{
			Console.WriteLine("\n---Cake Order---\n" + layers + " layer " + flavor + " cake with " + frosting + " frosting.\nTotal: " + price);
		}
	}
}
