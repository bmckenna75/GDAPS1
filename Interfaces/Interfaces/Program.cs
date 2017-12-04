using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	class Program
	{
		static void Main(string[] args)
		{
			Circle circle1 = new Circle(1, 1, 4);
			Circle circle2 = new Circle(8, 5, 7);
			Point point1 = new Point(1, 5);
			Point point2 = new Point(4, 3);

			//starting info
			Console.WriteLine(circle1.ToString());
			Console.WriteLine(circle2.ToString());
			Console.WriteLine(point1.ToString());
			Console.WriteLine(point2.ToString());

			//moves everything
			Console.WriteLine("\nMoving points and circles...\n\n");
			circle1.MoveTo(2, 2);
			circle2.MoveBy(-4, -2);
			point1.MoveTo(1, 1);
			point2.MoveBy(-4, -3);

			//next info pannel
			Console.WriteLine(circle1.ToString());
			Console.WriteLine(circle2.ToString());
			Console.WriteLine(point1.ToString());
			Console.WriteLine(point2.ToString());

			Console.WriteLine("The distance between the points is " + point1.DistanceTo(point2));
			Console.WriteLine("The distance between the first point and the second circle is " + point1.DistanceTo(circle2));

			if (circle1.IsLargerThan(circle2))
			{
				Console.WriteLine("\nThe first circle is larger than the second one");
			}
			else
			{
				Console.WriteLine("\nThe second circle is larger than the first one");
			}

			if (circle1.ContainsPosition(point1))
			{
				Console.WriteLine("Circle one contains point one");
			}
			if (circle2.ContainsPosition(point1))
			{
				Console.WriteLine("Circle two contains point one");
			}
			if (circle1.ContainsPosition(point2))
			{
				Console.WriteLine("Circle one contains point two");
			}
			if (circle2.ContainsPosition(point2))
			{
				Console.WriteLine("Circle two contains point two");
			}








		}
	}
}
