using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
	class Vehicle
	{
		//fields
		private string name;
		private double mileage = 0.0;



		public Vehicle ( string setName, double setMileage)
		{
			name = setName;
			mileage = setMileage;
		}
		/*
		public void SetMileage(double distance)
		{
			mileage = distance;
		}
		*/
		public void Drive(double distance)
		{
			mileage = mileage + distance;
		}
		public void Print()
		{
			Console.WriteLine(name + " : " + mileage);
		}

	}
}
