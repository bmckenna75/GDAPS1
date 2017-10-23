using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endVar = false;
            Book theHobbit;

            theHobbit = new Book(Console.ReadLine().Trim(), Console.ReadLine().Trim(),
                int.Parse(Console.ReadLine().Trim()), Console.ReadLine().Trim());
            //main loop
            do
            {
                Console.WriteLine("What would you like to do?");
                switch (Console.ReadLine().Trim().ToUpper())
                {
                    case "TITLE":
                        Console.WriteLine(theHobbit.Title);
                        continue;
                    case "AUTHOR":
                        Console.WriteLine(theHobbit.Author);
                        continue;
                    case "PAGES":
                        Console.WriteLine(theHobbit.TotalPages);
                        continue;
                    case "OWNER":
                        Console.WriteLine("Would you like to change the owner?");
                        if (Console.ReadLine().Trim().ToLower() == "yes")
                        {
                            Console.WriteLine("Enter the new owner: ");
                            theHobbit.Owner = Console.ReadLine();
                            Console.WriteLine(theHobbit.Owner + " is the owner");
                        }
                        else
                        {
                            Console.WriteLine(theHobbit.Owner + " is the owner");
                        }
                        continue;
                    case "READ":
                        theHobbit.TimesRead++;
                        Console.WriteLine("You have read the book " + theHobbit.TimesRead + " times.");
                        continue;
                    case "PRINT":
                        theHobbit.Print();
                        continue;
                    case "DONE":
                        endVar = true;
                        continue;
                    default:
                        Console.WriteLine("Invalid Input, Try again.");
                        continue;
                }


            }
            while (endVar == false);
        }
    }
}
