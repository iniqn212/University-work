using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLeters = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < numberOfLeters; i++)
            {
                string letter = Console.ReadLine();
                sum += letter[0];
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
