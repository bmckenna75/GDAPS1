using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	class Point : IPosition
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

		//constructor 
		public Point(double xValue, double yValue)
		{
			x = xValue;
			y = yValue;
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
		public override string ToString()
		{
			return "This point is at (" + x + ", " + y + ")";
		}


	}
}
