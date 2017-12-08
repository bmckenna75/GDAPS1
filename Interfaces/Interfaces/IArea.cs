using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	interface IArea
	{
		// Properties
		double Area { get; }
		double Perimeter { get; }

		// Methods
		bool ContainsPosition(IPosition position);
		bool IsLargerThan(IArea areaToCheck);
	}
}
