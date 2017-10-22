using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Monopoly
    {
        //constructor for dice using same convention as in main
        private Dice Roller;

        //string array for spot names
        private String[] propertyNames = {
    "Go",
    "Mediterranean Avenue",
    "Community Chest (1)",
    "Baltic Avenue",
    "Income Tax",
    "Reading Railroad",
    "Oriental Avenue",
    "Chance (1)",
    "Vermont Avenue",
    "Connecticut Avenue",
    "Jail",
    "St. Charles Place",
    "Electric Company",
    "States Avenue",
    "Virginia Avenue",
    "Pennsylvania Railroad",
    "St. James Place",
    "Community Chest (2)",
    "Tennessee Avenue",
    "New York Avenue",
    "Free Parking",
    "Kentucky Avenue",
    "Chance (2)",
    "Indiana Avenue",
    "Illinois Avenue",
    "B&O Railroad",
    "Atlantic Avenue",
    "Ventnor Avenue",
    "Water Works",
    "Marvin Gardens",
    "Go To Jail",
    "Pacific Avenue",
    "North Carolina Avenue",
    "Community Chest (3)",
    "Pennsylvania Avenue",
    "Short Line Railroad",
    "Chance (3)",
    "Park Place",
    "Luxury Tax",
    "Boardwalk"
        };

        private const int players = 100000;
        private const int goalLoop = 25;


        //default constructor
        public Monopoly()
        {
            Roller = new Dice();
        }

        //returns a double array of the number of times each is visited
        public double[] Analyze()
        {
            int[] visits = new int[40];
            int playerLocation = 0;
            int currentLoops = 1;
            int totalVisits = 0;
            double[] percentVisits = new double[40];

            for (int i = 0; i < 40; i++)
            {
                visits[i] = 0;
            }

            for (int i = 0; i < 40; i++)
            {
                percentVisits[i] = 0;
            }

            //loops for number of players
            for (int i = 0; i < players; i++)
            {

                do
                {
                    playerLocation = playerLocation + Roller.RollDice(2);

                    //loop rollover
                    if (playerLocation >= 40)
                    {
                        playerLocation = playerLocation % 40;
                        currentLoops++;
                    }

                    //marks the location as visited
                    visits[playerLocation]++;


                    //go to jail functionality
                    if (playerLocation == 30)
                    {
                        playerLocation = 10;
                        currentLoops++;
                    }
                                     

                }
                while (currentLoops <= 25);

            }
            for (int i = 0; i < 40; i++)
            {
                totalVisits = visits[i] + totalVisits;
            }
            for (int i = 0; i < 40; i++)
            {
                percentVisits[i] = ((double)visits[i] / (double)totalVisits) * (double)100;
            }
            return percentVisits;

        }


        //prints data very nicely
        public void PrintResults(double[] percents)
        {
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine(propertyNames[i].PadLeft(25) + " : " + percents[i]);
            }
        }




         


    }
}
