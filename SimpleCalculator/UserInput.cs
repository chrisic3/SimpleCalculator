using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SimpleCalculator
{
    public static class UserInput
    {
        public static string GetString()
        {
            string output = Console.ReadLine();
            return output;
        }

        public static double GetDouble()
        {
            bool isValidNumber;
            double output;

            do
            {
                string input = Console.ReadLine();
                isValidNumber = double.TryParse(input, out output);

                if (!isValidNumber)
                {
                    Console.Write("That was not a valid number. Please try again: ");
                }
            } while (!isValidNumber);

            return output;
        }
    }
}
