using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
	class Bakery
	{
		//constructor
		public Bakery()
		{

		}

		//methods
		public BakedGood Bake(DessertType food)
		{
			BakedGood Dessert;
			if (food == DessertType.cake)
			{
				Console.WriteLine("What flavor cake would you like?");
				string flavor = Console.ReadLine().Trim();
				Console.WriteLine("What flavor icing would you like?");
				string frost = Console.ReadLine().Trim();
				Console.WriteLine("How many layers would you like");
				int layers = int.Parse(Console.ReadLine().Trim());
				Dessert = new Cake(flavor, frost, layers);
			}
			else
			{
				Console.WriteLine("What filling would you like?");
				string filling = Console.ReadLine().Trim();
				Dessert = new Pie(filling);
			}
			return Dessert;
		}

	}
}
