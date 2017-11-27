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
				Stream inStream = File.OpenRead("players.data");
				BinaryReader input = new BinaryReader(inStream);

                string[] values = new string[3];

				int numToLoad = input.ReadInt32();

				for (int i = 0; i < numToLoad; i++)
				{
					string name = input.ReadString();
					int str = input.ReadInt32();
					int hp = input.ReadInt32();
					this.CreatePlayer(name, str, hp);
				}
				input.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Save()
        {
            try
            {
				Stream outStream = File.OpenWrite("players.data");
				BinaryWriter output = new BinaryWriter(outStream);
				
                if (players.Count == 0)
                {
                    Console.WriteLine("There is nothing to write, please create player data and try again");

                }
                else
                {
					output.Write(players.Count);
                    foreach (Player n in players)
                    {
						output.Write(n.Name);
						output.Write(n.Strength);
						output.Write(n.Health);
                    }
                    output.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
