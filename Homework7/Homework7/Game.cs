using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
	class Game
	{
		Random rng = new Random();
		Cell[,] currentBoard;
		Cell[,] nextBoard;
		int width;
		int height;


		public void Generate()
		{
			width = rng.Next(10, 21);
			height = rng.Next(10, 21);
			currentBoard = new Cell[height, width];
			nextBoard = new Cell[height, width];
			for (int i = 0; i < height; i++)
			{
				for (int y = 0; y < width; y++)
				{
					currentBoard[i, y] = new Cell(rng.Next(1, 4));
				}
			}
		}

		//used to display the board
		public void Print()
		{
			Console.Clear();
			for (int i = 0; i <= height - 1; i++)
			{
				for (int y = 0; y <= width - 1; y++)
				{
					if (currentBoard[i, y].Alive == true)
					{
						Console.ForegroundColor = ConsoleColor.Green;
					}
					else if (currentBoard[i, y].Alive != true)
					{
						Console.ForegroundColor = ConsoleColor.Red;
					}
					Console.Write(currentBoard[i, y].ToString());
					Console.ResetColor();
					if (y == width - 1)
					{
						Console.WriteLine();
					}
				}
			}
			Console.ReadKey();
			Console.Clear();
		}

		//WARNING: THIS IS FAR TOO MANY FOR LOOPS
		public int Count()
		{
			int neighbors = 0;
			for (int i = 0; i < height; i++)
			{
				for (int y = 0; y < width; y++)
				{
					if (i == 0)
					{
						//top left corner checker
						if (y == 0)
						{
							if (currentBoard[i + 1, y].Alive == true)
							{
								neighbors++;
							}
							if (currentBoard[i + 1, y + 1].Alive == true)
							{
								neighbors++;
							}
							if (currentBoard[i, y + 1].Alive == true)
							{
								neighbors++;
							}
						}
						//top right corner checker
						else if (y == width)
						{
							if (currentBoard[i + 1, y].Alive == true)
							{
								neighbors++;
							}
							if (currentBoard[i + 1, y - 1].Alive == true)
							{
								neighbors++;
							}
							if (currentBoard[i, y - 1].Alive == true)
							{
								neighbors++;
							}
						}
						//top row corner checker
						else
						{
							if (currentBoard[i + 1, y].Alive == true)
							{
								neighbors++;
							}
							if (currentBoard[i + 1, y - 1].Alive == true)
							{
								neighbors++;
							}
							if (currentBoard[i + 1, y + 1].Alive == true)
							{
								neighbors++;
							}
							if (currentBoard[i, y - 1].Alive == true)
							{
								neighbors++;
							}
							if (currentBoard[i, y + 1].Alive == true)
							{
								neighbors++;
							}
						}

					}

				}
			}
			return neighbors;
		}






	}
}
