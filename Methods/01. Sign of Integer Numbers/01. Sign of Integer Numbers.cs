using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            checker(number);

            Console.WriteLine(checker(number));

        }

        private static string checker(int number)
        {
            string result = string.Empty;

            if (number > 0 )
            {
                 result = $"The number {number} is positive.";
            }
            else if (number < 0)
            {
                result = $"The number {number} is negative.";
            }
            else
            {
                result = $"The number {number} is zero.";
            }

            return result;
        }
    }
}
