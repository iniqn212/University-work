using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] lineOne = new int[n];
            int[] lineTwo = new int[n];

            for (int i = 0; i < n ; i++)
            {
                int[] nums = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToArray();
                int firstNum = nums[0];
                int secondNum = nums[1];

                if (i % 2 == 0)
                {
                    lineOne[i] = firstNum;
                    lineTwo[i] = secondNum;
                }
                else
                {
                    lineOne[i] = secondNum;
                    lineTwo[i] = firstNum;
                }
            }
            Console.WriteLine(String.Join(" ", lineOne));
            Console.WriteLine(String.Join(" ", lineTwo));
        }
    }
}
