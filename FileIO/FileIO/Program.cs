using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
	class Program
	{
		static void Main(string[] args)
		{
			StreamReader input;
			StreamWriter output;
			bool exit = false;
			List<string> players = new List<string>();

			while (exit == false)
			{

				Console.WriteLine("Please choose an option:");
				Console.WriteLine("1 - Enter Data\n2 - Save Data\n3 - Load Data");
				string swap = Console.ReadLine().Trim().ToUpper();
				if (swap == "1" || swap == "ENTER DATA")
				{
					Console.WriteLine("How many players are there?");
					int playerNum = int.Parse(Console.ReadLine());
					for (int i = 1; i <= playerNum; i++)
					{
						Console.Write("Please enter Player " + i + "'s name: ");
						players.Add(Console.ReadLine());
					}
				}
				if (swap == "2" || swap == "SAVE DATA")
				{
					output = new StreamWriter("player.txt");
					foreach (string n in players)
					{
						output.WriteLine(n);
					}
					output.Close();
					Console.WriteLine("File Saved");
				}
				if (swap == "3" || swap == "LOAD DATA")
				{
					players.Clear();
					input = new StreamReader("player.txt");
					try
					{
						String line = null;
						while ((line = input.ReadLine()) != null)
						{
							players.Add(line);
						}
					}
					catch (Exception e)
					{
						Console.WriteLine("Ouch, the error code is: " + e.Message);
					}

					if (players.Count > 0)
					{
						input.Close();
					}
					else
					{
						
					}
					foreach(string n in players)
					{
						Console.WriteLine(n);
					}

				}
				if (swap == "QUIT")
				{
					exit = true;
				}
			}
		}
	}
}
