using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			//Reformatted bank to
			string name = "Name: Zera Straxus"; 
			const double startingPoints = 50;
			string role = "Class: Wizard";
			double dex = startingPoints * .2;
			double str = startingPoints * .2 * .5;
			double intel = 7;
			double con = (startingPoints * .2 + startingPoints * .2 * .5) - 2;
			double cha = (startingPoints - str - dex - intel - con);
			double tot = dex + str + intel + con + cha;

			// Prints Everything
			Console.WriteLine(role);
			Console.WriteLine();
			Console.WriteLine(name);
			Console.WriteLine("Dex: " + dex);
			Console.WriteLine("Str: " + str);
			Console.WriteLine("Int: " + intel);
			Console.WriteLine("Con: " + con);
			Console.WriteLine("Cha: " + cha);
			Console.WriteLine();
			Console.WriteLine("Total: " + tot);
		}
	}
}
