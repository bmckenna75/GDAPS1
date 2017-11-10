using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {

            Random Roller = new Random();
            CommonCharacter Lei = new Shadowdancer("Lei", 25, 16, 14, 11, 13, false, true);
            CommonCharacter Zera = new Archmage("Zera", 17, 13, 8, 14, 12, 0, true);
            CommonCharacter Bob = new CommonCharacter();
            CommonCharacter Gandalf = new Archmage();
            int roundCount = 0;
            List<CommonCharacter> contestants = new List<CommonCharacter>();
            contestants.Add(Lei);
            contestants.Add(Zera);
            contestants.Add(Bob);
            contestants.Add(Gandalf);
            do
            {
                roundCount++;
                Console.WriteLine("\n\nRound " + roundCount + "\n====================================================================");

                foreach (CommonCharacter c in contestants)
                {
                    int target;
                    do
                    {
                        target = Roller.Next(0, contestants.Count);
                    }
                    while (c == contestants[target]);
                    int roundDamage;

                    if (c is Shadowdancer)
                    {
                        roundDamage = c.Attack(contestants[target].ArmorClass);
                    }
                    else if (c is CommonCharacter)
                    {
                        roundDamage = c.Attack(contestants[target].ArmorClass);
                    }
                    else if (c is Archmage)
                    {
                        roundDamage = c.Attack(contestants[target].ArmorClass);
                    }
                    else { roundDamage = 0; }

                    Console.WriteLine(c.Name + " attacks " + contestants[target].Name + " dealing " + roundDamage + " points of damage!");
                    contestants[target].TakeDamage(roundDamage);


              
                }
                for (int i = 0; i < contestants.Count; i++)
                {
                    if (contestants[i].IsDead() == true)
                    {
                        Console.WriteLine(contestants[i].Name + " has been knocked out!");
                        contestants.RemoveAt(i);
                        i--;
                        continue;
                    }
                    if (contestants[i].HasFled() == true)
                    {
                        Console.WriteLine(contestants[i].Name + " has fled!");
                        contestants.RemoveAt(i);
                        i--;
                        continue;
                    }
                }



                System.Threading.Thread.Sleep(500);

            }
            while (contestants.Count > 1);

            if (contestants.Count == 1)
            {
                Console.WriteLine("Congratulations! " + contestants[0].Name + " is the last contestant standing!\n\nYou Win!");
            }
            else
            {
                Console.WriteLine("There has been a tie! All contestants have been defeated!");
            }

        }

    }


}



