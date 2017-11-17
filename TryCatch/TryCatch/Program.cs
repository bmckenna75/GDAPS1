using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("Please enter anything or quit.");
                string userInput = Console.ReadLine();
                if (userInput.Trim().ToLower() == "quit")
                {
                    exit = true;
                    continue;
                }
                else
                {
                    //ints
                    try
                    {
                        int usrInt = int.Parse(userInput);
                        Console.WriteLine(userInput + " is an Int");
                    }
                    catch
                    {
                        Console.WriteLine(userInput + " is Not an Int");
                    }
                    //doubles
                    try
                    {
                        double usrDouble = double.Parse(userInput);
                        Console.WriteLine(userInput + " is a Double");
                    }
                    catch
                    {
                        Console.WriteLine(userInput + " is Not a Double");
                    }
                    //bools
                    try
                    {
                        bool usrBool = bool.Parse(userInput);
                        Console.WriteLine(userInput + " is a Bool");
                    }
                    catch
                    {
                        Console.WriteLine(userInput + " is Not a Bool");
                    }
                    //chars
                    try
                    {
                        char usrChar = char.Parse(userInput);
                        Console.WriteLine(userInput + " is a Char");
                    }
                    catch
                    {
                        Console.WriteLine(userInput + " is Not a Char");
                    }





                }
            }
        }
    }
}
