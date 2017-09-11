using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingandUSRInput
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to MadLibs!!!");

			Console.WriteLine();
			Console.WriteLine();
			// 1
			Console.Write("1: Government Department: ");
			string gvmtDept = Console.ReadLine();
			// 2
			Console.Write("2: Adjective: ");
			string cafAdjective = Console.ReadLine();
			// 3
			Console.Write("3: Adjective: ");
			string dietAdjective = Console.ReadLine();
			//4
			Console.Write("4: Noun: ");
			string ballNoun = Console.ReadLine();
			// 5
			Console.Write("5: Adjective: ");
			string saladAdjective = Console.ReadLine();
			// 6
			Console.Write("6: Food: ");
			string foodFrench = Console.ReadLine();
			// 7
			Console.Write("7: Animal: ");
			string animalFries = Console.ReadLine();
			// 8
			Console.Write("8: Body Part: ");
			string bodyPart = Console.ReadLine();
			// 9
			Console.Write("9: Noun: ");
			string vomitNoun = Console.ReadLine();
			// 10
			Console.Write("10: Person's Name: ");
			string personName = Console.ReadLine();
			// 11
			Console.Write("11: Bland Food: ");
			string blandFoodOne = Console.ReadLine();
			// 12 Bland var names for bland foods
			Console.Write("12: Bland Food: ");
			string blandFoodTwo = Console.ReadLine();
			// 13
			Console.Write("13: Vitamin or Mineral: ");
			string vitaminMineral = Console.ReadLine();
			// 14
			Console.Write("14: Number between 1 and 10: ");
			string rating = Console.ReadLine();
			int ratingFinal = int.Parse(rating);
			ratingFinal = ratingFinal - 10;



			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("An inspector from the Department of Health and " + gvmtDept + " Services");
			Console.WriteLine("paid a surprise visit to our" + cafAdjective + " school cafeteria.");
			Console.WriteLine("The lunch special, prepared by our " + dietAdjective + " dietician, was spaghetti and " + ballNoun + "-balls with a choice");
			Console.WriteLine("of either a " + saladAdjective + "salad or French " + foodFrench + ".");
			Console.WriteLine("The inspector found the" + ballNoun + "-balls to be overcooked and discovered a live" + animalFries + "in the fries,");
			Console.WriteLine("causing him to have a " + bodyPart + " ache. In response, he threw up all over his " + vomitNoun + ".");
			Console.WriteLine("In his report, the Inspector " + personName + " recommended that the school cafeteria serve only nutritious" + blandFoodOne + " as well as");
			Console.WriteLine("low-calorie " + blandFoodTwo + " , and that all of the saturated " + vitaminMineral + " be eliminated. He rated the cafeteria a " + ratingFinal + " - minus.");
			

			/*
			[1] government department
			[2] adjective
			[3] adjective
			[4] noun
			[5] adjective
			[6] food
			[7] animal
			[8] body part
			[9] noun
			[10] person's name
			[11] bland food
			[12] bland food
			[13] vitamin or mineral
			[14] number between 1 and 10(minus 10)
			*/
		}
	}
}
