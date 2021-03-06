﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Rogue Thomas = new Rogue("Thomas", 12, 16, 14, 0);
            Wizard Lei = new Wizard("Lei", 10, 14, 17, 76.8);
            Warrior Zera = new Warrior("Zera", 16, 15, 13, 0);


            Console.WriteLine(Thomas.ToString());
            Console.WriteLine(Lei.ToString());
            Console.WriteLine(Zera.ToString());

            Zera.DaysWithoutBath = 12;
            Lei.HotPocketPercent = 56.8;
            Thomas.CellPhoneRings = 4;

            Console.WriteLine(Thomas.ToString());
            Console.WriteLine(Lei.ToString());
            Console.WriteLine(Zera.ToString());

            Zera.TakeBath();
            Thomas.SmashPhone();
            Lei.GainXP(500);
            Thomas.GainXP(500);
            Zera.GainXP(500);

            Console.WriteLine(Zera);
            Console.WriteLine(Lei);
            Console.WriteLine(Thomas);




            Console.WriteLine("\n\n\n\n\n");
            Barracks Spawner = new Barracks();

            List<RPGChar> finalList = new List<RPGChar>();
            List<RPGChar> people = new List<RPGChar>();
            for (int i = 0; i < 10; i++)
            {
                RPGChar person = Spawner.SpawnChar("Sebastian", 14, 14, 14);
                people.Add(person);
                Console.WriteLine(person.ToString());
            }
            foreach (RPGChar n in people)
            {
                if (n is Rogue)
                {
                    Rogue child = (Rogue)n;
                    child.Heist();
                    child.Heist();
                    
                }
                else if (n is Wizard)
                {
                    Wizard child = (Wizard)n;
                    child.HotPocketPercent = 12.3;
                    
                }
                else if (n is Warrior)
                {
                    Warrior child = (Warrior)n;
                    child.DaysWithoutBath = 3;
                    
                }

            }

            Console.WriteLine("\n\n\n\n\n");

            foreach (RPGChar n in people)
            {
                Console.WriteLine(n.ToString());
            }







        }
    }
}
