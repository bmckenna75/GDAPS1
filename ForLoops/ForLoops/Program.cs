using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
	class Program
	{
		static void Main(string[] args)
		{
			//width
			Console.WriteLine("How wide do you want the box to be? ");
			int width = int.Parse(Console.ReadLine().Trim());
			//height
			Console.WriteLine("How high do you want the box to be? ");
			int height = int.Parse(Console.ReadLine().Trim());


			for (int i = 0; i < (height); i++)
			{
				Console.WriteLine();
				for (int j = 0; j < (width); j++)
				{
					if (j == 0 || j == (width - 1))
					{
						Console.Write("#");

					}
					else if (i == 0 || i == (height - 1))
					{
						Console.Write("#");
					}
					else
					{
						Console.Write(" ");
					}
					
				}
			}






		}
	}
}
