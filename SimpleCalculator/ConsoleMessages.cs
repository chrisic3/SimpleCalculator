using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public static class ConsoleMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to our Simple Calculator App.");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
        }

        public static void AskForFirstName()
        {
            Console.Write("Let's start with your first name: ");
        }

        public static void GreetUser(string firstName)
        {
            int currentHour = DateTime.Now.Hour;

            if (currentHour < 12)
            {
                Console.WriteLine($"Good morning, {firstName}.");
            }
            else if (currentHour < 17)
            {
                Console.WriteLine($"Good afternoon, {firstName}.");
            }
            else
            {
                Console.WriteLine($"Good evening, {firstName}");
            }

            Console.WriteLine();
        }

        public static void AskForNumber(char number)
        {
            Console.Write($"Please give me a number for {number}: ");
        }

        public static void PrintResults(double add, double subtract, double multiply, double divide)
        {
            Console.WriteLine("The results of all four calculations are as follows:");
            Console.WriteLine($"Add: {add}");
            Console.WriteLine($"Subtract: {subtract}");
            Console.WriteLine($"Multiply: {multiply}");
            Console.WriteLine($"Divide: {divide}");
        }
    }
}
