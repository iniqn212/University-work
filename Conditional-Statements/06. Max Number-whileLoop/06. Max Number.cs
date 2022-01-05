using System;

namespace _06._Max_Number_whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
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
