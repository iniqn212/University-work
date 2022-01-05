using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rates = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int entryPoint = int.Parse(Console.ReadLine());

            string typeOfItem = Console.ReadLine();

            List<int> Left = new List<int>();
            List<int> Right = new List<int>();

            

            for (int i = 0; i < entryPoint; i++)
            {
                Left.Add(rates[i]);
            }

            for (int j = entryPoint + 1; j < rates.Length; j++)
            {
                Right.Add(rates[j]);
            }

            int leftSum = Left.Sum();
            int rightSum = Right.Sum();

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else if (typeOfItem == "cheap")
            {
                if (leftSum < rightSum)
                {
                    Console.WriteLine($"Left - {leftSum}");
                }
                else
                {
                    Console.WriteLine($"Right - {rightSum}");
                }

            }
            else
            {

                if (leftSum > rightSum)
                {
                    Console.WriteLine($"Left - {leftSum}");
                }
                else
                {
                    Console.WriteLine($"Right - {rightSum}");
                }
            }
        }
    }
}
