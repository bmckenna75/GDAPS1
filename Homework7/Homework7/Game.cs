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
        int width = 0;
        int height;


        public void Generate()
        {
            height = rng.Next(10, 21);
            width = height;
            while (width < height);
            currentBoard = new Cell[height, width];
            nextBoard = new Cell[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int y = 0; y < width; y++)
                {
                    currentBoard[i, y] = new Cell(rng.Next(1, 4));
                }
            }
            nextBoard = currentBoard;
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
            Console.WriteLine("\n\nWould you like to advance the board?(Y/N)");
            if (Console.ReadLine().Trim().ToLower() == "y")
            {
                Console.Clear();
                this.Advance();
            }
            Console.Clear();
        }

        //WARNING: THIS IS FAR TOO MANY FOR LOOPS
        //after note: 200 LINES. TWO HUNDRED LINES
        /// <summary>
        /// Input the coordinates of the point you would like to count
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Count(int x, int y)
        {
            int neighbors = 0;

            //left row checker
            if (x == 0)
            {
                //top left corner checker
                if (y == 0)
                {
                    if (currentBoard[x + 1, y].Alive == true)
                    {
                        neighbors++;
                    }
                    if (currentBoard[x + 1, y + 1].Alive == true)
                    {
                        neighbors++;
                    }
                    if (currentBoard[x, y + 1].Alive == true)
                    {
                        neighbors++;
                    }
                }
                //bottom left corner checker
                else if (y == height - 1)
                {
                    if (currentBoard[x + 1, y].Alive == true)
                    {
                        neighbors++;
                    }
                    if (currentBoard[x + 1, y + 1].Alive == true)
                    {
                        neighbors++;
                    }
                    if (currentBoard[x, y + 1].Alive == true)
                    {
                        neighbors++;
                    }
                }
                //left row checker
                else
                {
                    if (currentBoard[x + 1, y].Alive == true)
                    {
                        neighbors++;
                    }
                    if (currentBoard[x + 1, y - 1].Alive == true)
                    {
                        neighbors++;
                    }
                    try
                    {
                        if (currentBoard[x + 1, y + 1].Alive == true)
                        {
                            neighbors++;
                        }
                    }
                    catch
                    {

                    }
                    if (currentBoard[x, y - 1].Alive == true)
                    {
                        neighbors++;
                    }
                    try
                    {
                        if (currentBoard[x, y + 1].Alive == true)
                        {
                            neighbors++;
                        }
                    }
                    catch { }
                }
            }
            //right side checker
            else if (x == width - 1)
            {
                //top right corner checker
                if (y == 0)
                {
                    if (currentBoard[x - 1, y].Alive == true)
                    {
                        neighbors++;
                    }
                    if (currentBoard[x - 1, y + 1].Alive == true)
                    {
                        neighbors++;
                    }
                    if (currentBoard[x, y + 1].Alive == true)
                    {
                        neighbors++;
                    }
                }
                //bottom right corner checker
                else if (y == height - 1)
                {
                    if (currentBoard[x - 1, y].Alive == true)
                    {
                        neighbors++;
                    }
                    if (currentBoard[x - 1, y - 1].Alive == true)
                    {
                        neighbors++;
                    }
                    if (currentBoard[x, y - 1].Alive == true)
                    {
                        neighbors++;
                    }
                }
                //right row checker
                else
                {
                    if (currentBoard[x - 1, y].Alive == true)
                    {
                        neighbors++;
                    }
                    if (currentBoard[x - 1, y - 1].Alive == true)
                    {
                        neighbors++;
                    }
                    if (currentBoard[x - 1, y + 1].Alive == true)
                    {
                        neighbors++;
                    }
                    if (currentBoard[x, y - 1].Alive == true)
                    {
                        neighbors++;
                    }
                    try
                    {
                        if (currentBoard[x, y + 1].Alive == true)
                        {
                            neighbors++;
                        }
                    }
                    catch { }
                }
            }
            //top row

            else if (y == 0)
            {
                try
                {
                    if (currentBoard[x + 1, y + 1].Alive == true)
                    {
                        neighbors++;
                    }
                }
                catch { }
                try
                {
                    if (currentBoard[x + 1, y].Alive == true)
                    {
                        neighbors++;
                    }
                }
                catch { }
                if (currentBoard[x - 1, y + 1].Alive == true)
                {
                    neighbors++;
                }
                if (currentBoard[x - 1, y].Alive == true)
                {
                    neighbors++;
                }
                try
                {
                    if (currentBoard[x, y + 1].Alive == true)
                    {
                        neighbors++;
                    }
                }
                catch { }
            }

            //bottom row

            else if (y == height - 1)
            {
                if (currentBoard[x + 1, y - 1].Alive == true)
                {
                    neighbors++;
                }
                if (currentBoard[x + 1, y].Alive == true)
                {
                    neighbors++;
                }
                if (currentBoard[x - 1, y - 1].Alive == true)
                {
                    neighbors++;
                }
                if (currentBoard[x - 1, y].Alive == true)
                {
                    neighbors++;
                }
                if (currentBoard[x, y - 1].Alive == true)
                {
                    neighbors++;
                }
            }
            //general solution
            else
            {
                try
                {
                    if (currentBoard[x + 1, y - 1].Alive == true)
                    {
                        neighbors++;
                    }
                }
                catch { }
                try
                {
                    if (currentBoard[x + 1, y].Alive == true)
                    {
                        neighbors++;
                    }
                }
                catch { }
                try
                {
                    if (currentBoard[x + 1, y + 1].Alive == true)
                    {
                        neighbors++;
                    }
                }
                catch { }
                if (currentBoard[x - 1, y - 1].Alive == true)
                {
                    neighbors++;
                }
                if (currentBoard[x - 1, y].Alive == true)
                {
                    neighbors++;
                }
                if (currentBoard[x, y + 1].Alive == true)
                {
                    neighbors++;
                }
                if (currentBoard[x, y - 1].Alive == true)
                {
                    neighbors++;
                }
                if (currentBoard[x, y + 1].Alive == true)
                {
                    neighbors++;
                }
            }
            return neighbors;
        }

        //advances the board state by one iteration
        public void Advance()
        {
            for (int y = 0; y < height - 1; y++)
            {
                for (int x = 0; x < width - 1; x++)
                {
                    int aliveCells = this.Count(x, y);
                    //simple logic to determine what happens to the cell
                    if (aliveCells < 2)
                    {
                        nextBoard[x, y].Alive = false;
                    }
                    else if (aliveCells == 2 || aliveCells == 3)
                    {
                        nextBoard[x, y].Alive = true;
                    }
                    else if (aliveCells > 3)
                    {
                        nextBoard[x, y].Alive = false;
                    }
                }
            }

            //update board and display
            currentBoard = nextBoard;
            this.Print();
        }
    }
}
