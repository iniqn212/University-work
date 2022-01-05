using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
            string input = Console.ReadLine();
        int maxValue = int.MinValue;

            while (input != "Stop")
            {
                int number = int.Parse(input);

                if (number > maxValue)
                {
                    maxValue = number;
                }
    input = Console.ReadLine();
            }
Console.WriteLine(maxValue);
        }
    }
}