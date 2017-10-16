using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOP
{
	class Program
	{
		static void Main(string[] args)
		{
			Vehicle ModelS = new Vehicle("Bobby", 178489.5);
			Vehicle ModelE = new Vehicle("Michael", 56237.3);

			//drives 11 miles
			ModelS.Drive(11);

			//prints milage
			ModelS.Print();

		}
	}
}
