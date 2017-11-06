using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McKenna_PracticalExam2
{
    class Player
    {
        //fields
        private string name;
        private int score;

        public string Name
        {
            get { return name; }
        }
        public int Score
        {
            get { return score; }
        }

        //default constructor
        public Player() 
        {
            name = "John";
            score = 0;
        }

        
        public Player(string n)
        {
            name = n;
            score = 0;
        }




        //methods
        public void AddDiceToScore(int[] array)
        {
            int roll = int.MaxValue;
            int index = -1;
            int total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (roll > array[i])
                {
                    roll = array[i];
                    index = i;
                }
                Console.WriteLine(array[i]);
            }
            array[index] = 0;
            for (int i = 0; i < array.Length; i++)
            {
                total += array[i];
            }
            score += total;
            Console.WriteLine("Your score is now " + score);
        }




    }
}
