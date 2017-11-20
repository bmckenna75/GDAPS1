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
            width = rng.Next(5, 21);
            height = rng.Next(5, 21);
            currentBoard = new Cell[height, width];
            nextBoard = new Cell[height, width];
            for (int i = 0; i < height; i++)
            {
                for( int y = 0; y < width; y++)
                {
                    currentBoard[i, y] = new Cell();
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i <= height-1; i++)
            {
                for (int y = 0; y <= width-1; y++)
                {
					if (currentBoard[i,y].Alive == true)
					{
						Console.ForegroundColor = ConsoleColor.Green;
					}
					else if (currentBoard[i, y].Alive != true)
					{
						Console.ForegroundColor = ConsoleColor.Red;
					}
					Console.Write(currentBoard[i, y].ToString());
					Console.ResetColor();
                    if (y == width-1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }

    }
}
