using System;

namespace Ass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome\nPls enter your program");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "full time"){
                Console.WriteLine("Enter your course");
                Console.Write(Console.ReadLine() + " is a good course");
            } else if (userInput == "part time"){
                Console.WriteLine("How many credit are you taking?");
                int UserCreditNo = int.Parse(Console.ReadLine());
                if (UserCreditNo > 6) {
                    Console.WriteLine("Too much unit for a part-time student");
                    if (UserCreditNo <= 6) {
                        Console.WriteLine("proceed to screen");
                    } else {
                        Console.WriteLine("You enter the wrong input");
                    }

                } else {
                    Console.WriteLine("proceed to screen");
                }

            }
        }
    }
}
