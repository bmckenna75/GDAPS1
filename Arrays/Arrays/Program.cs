using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			int assignmentNumber;

			do
			{
				Console.WriteLine("Please enter the number of assignments you would like to average (greater than 0): ");
				assignmentNumber = int.Parse(Console.ReadLine());
			}
			while (assignmentNumber < 1);

			string[] assignmentName = new string[assignmentNumber];
			double[] grade = new double[assignmentNumber];

			for (int i = 0; i < assignmentNumber; i++)
			{
				Console.WriteLine("Enter the assignment name: ");
				assignmentName[i] = Console.ReadLine();
				Console.WriteLine("Enter the assignment grade: ");
				grade[i] = double.Parse(Console.ReadLine());
			}

			double finalGrade = (grade.Sum() / assignmentNumber);
			Console.WriteLine("Grade Report: ");
			for (int i = 0; i < assignmentNumber; i++)
			{
				Console.WriteLine(assignmentName[i] + ": " + grade[i] + "%");
			}

			Console.WriteLine("Your final grade is " + finalGrade + "%" + 
				"\n\n You now have the chance to replace one grade. Which one would you like to replace?");

			int replacementValue = 0;
			do
			{
				if (!(replacementValue < assignmentNumber && replacementValue >= 0))
				{
					Console.WriteLine("That's an invalid value. Try again.");
				}
				else
				{

				}
				replacementValue = (int.Parse(Console.ReadLine()) - 1);

			}
			while (!(replacementValue < assignmentNumber && replacementValue >= 0));

			Console.WriteLine("What would you like the replaced grade to be?");
			grade[replacementValue] = double.Parse(Console.ReadLine());


			finalGrade = (grade.Sum() / assignmentNumber);
			Console.WriteLine("Grade Report: ");
			for (int i = 0; i < assignmentNumber; i++)
			{
				Console.WriteLine(assignmentName[i] + ": " + grade[i] + "%");
			}

			Console.WriteLine("Your final grade is " + finalGrade + "%");


		}
	}
}
