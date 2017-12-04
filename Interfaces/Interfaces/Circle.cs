using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	class Circle : IPosition, IArea
	{
		//fields
		protected double x;
		public double X
		{
			get { return x; }
			set { x = value; }
		}
		protected double y;
		public double Y
		{
			get { return y; }
			set { y = value; }
		}
		protected double area;
		public double Area
		{
			get { return area; }
		}
		protected double perimeter;
		public double Perimeter
		{
			get { return perimeter; }
		}

		//constructor
		public Circle(double xValue, double yValue, double radius)
		{
			x = xValue;
			y = yValue;
			area = Math.PI * Math.Pow(radius, 2);
			perimeter = Math.PI * radius * 2;
		}

		//methods
		public double DistanceTo(IPosition position)
		{
			double distance;
			distance = Math.Pow((Math.Pow(position.X - x, 2)) + Math.Pow(position.Y - y, 2), .5);
			return distance;
		}
		public void MoveTo(double x, double y)
		{
			this.X = x;
			this.Y = y;
		}
		public void MoveBy(double xOffset, double yOffset)
		{
			x += xOffset;
			y += yOffset;
		}
		public bool ContainsPosition(IPosition position)
		{
			if (this.DistanceTo(position) <= perimeter / (2 * Math.PI))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool IsLargerThan(IArea areaToCheck)
		{
			if (areaToCheck.Area < area)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public override string ToString()
		{
			return "This circle is centered on (" + x + ", " + y + ") and has an area of " + area + " with a perimeter of " + perimeter;
		}

	}
}
