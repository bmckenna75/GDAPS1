using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSplit
{
	class PlayerManager
	{
		//field
		protected List<Player> players;

		public PlayerManager()
		{
			players = new List<Player>();
		}

		//methods
		public void CreatePlayer(string n, int s, int h)
		{

			players.Add(new Player(n, s, h));
			Console.WriteLine("Player, " + n + " created...");
		}

		public void Print()
		{
			foreach (Player n in players)
			{
				Console.WriteLine(n.ToString());
			}
			if (players.Count == 0)
			{
				Console.WriteLine("There is no player data to print.");
			}
		}

		public void Load()
		{
			try
			{
				StreamReader list = new StreamReader("players.txt");
				string data = null;

				string[] values = new string[3];
				do
				{
					data = list.ReadLine();
					values = data.Split(',');
					this.CreatePlayer(values[0], int.Parse(values[1]), int.Parse(values[2]));
				}
				while (data != null);
				list.Close();
			}
			catch
			{
				Console.WriteLine("Error opening string, please consult developers.");
			}
		}

		public void Save()
		{
			try
			{
				StreamWriter output = new StreamWriter("players.txt");
				if (players.Count == 0)
				{
					Console.WriteLine("There is nothing to write, please create player data and try again");

				}
				else
				{
					foreach(Player n in players)
					{
						output.WriteLine(n.Name + "," + n.Strength + "," + n.Health);
					}
					output.Close();
				}

			}
			catch
			{
				Console.WriteLine("There was an issue with the specified file, no data written.");
			}
		}


	}
}
