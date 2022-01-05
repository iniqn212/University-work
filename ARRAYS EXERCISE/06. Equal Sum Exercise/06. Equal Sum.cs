using System;
using System.Linq;

namespace _06._Equal_Sum_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            bool exist = false;

            for (int i = 0; i < array.Length; i++)
            {
                int leftsum = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    leftsum += array[j];

                }

                int rightSum = 0;
                for (int j = i + 1; j < array.Length; j++)
                {
                    rightSum += array[j];
                }

                if (leftsum == rightSum)
                {
                    Console.WriteLine(i);
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                Console.WriteLine("no");
            }
        }
    }
}
