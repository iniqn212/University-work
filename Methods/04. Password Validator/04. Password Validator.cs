using System;
using System.Collections.Generic;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isLengthEnough = InputLength(input);
            bool isLetterAndDigits = InputLetterAndDigits(input);
            bool isMinTwoDigits = InputDigitsCheck(input);

            if (isLengthEnough && isLetterAndDigits && isMinTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
            if (!isLengthEnough)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isLetterAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isMinTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

        }

        private static bool InputDigitsCheck(string input)
        {
            bool isMinTwoDigits = false;
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    counter++;
                }
            }

            if (counter >= 2)
            {
                isMinTwoDigits = true;
            }
            return isMinTwoDigits;
        }

        private static bool InputLetterAndDigits(string input)
        {
            bool isLetterAndDigits = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (!(char.IsLetterOrDigit(input[i])))
                {
                    isLetterAndDigits = false;
                }
                
            }
            return isLetterAndDigits;
        }

        private static bool InputLength(string input)
        {
            bool isLengthEnought = false;
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                counter++;
            }

            if (counter >= 6 && counter <= 10)
            {
                isLengthEnought = true;
            }

            return isLengthEnought;
        }
    }
}
