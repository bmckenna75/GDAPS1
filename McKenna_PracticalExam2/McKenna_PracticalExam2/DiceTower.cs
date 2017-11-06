using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McKenna_PracticalExam2
{
    class DiceTower
    {
        private Random rng;

        //initalizes Random
        public DiceTower()
        {
            rng = new Random();
        }


        //methods

        public int[] GenerateDiceRolls(int number, int sides)
        {
            int[] numbers = new int[number];
            //This fills the array
            for (int i = 0; i < number; i++)
            {
                numbers[i] = rng.Next(1, (sides + 1));
            }
            return numbers;
        }




    }
}
