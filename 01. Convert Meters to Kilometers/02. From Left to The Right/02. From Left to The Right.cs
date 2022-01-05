using System;
using System.Linq;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRange = int.Parse(Console.ReadLine());

            for (int i = 0; i < numRange; i++)
            {
                string[] data = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)    
                    .ToArray();

                long leftNum = long.Parse(data[0]);
                long rightSum = long.Parse(data[1]);

                if (leftNum > rightSum)
                {
                    Console.WriteLine(Sum(leftNum));
                }
                else
                {
                    Console.WriteLine(Sum(rightSum));
                }

            }
        }

        private static long Sum(long num)
        {
            long sum = 0;
            num = Math.Abs(num);

            if (num < 0 )
            {
                while (num < 0)
                {
                    sum += num % 10;
                    num /= 10;

                }
            }
            else
            {
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;

                }
            }

            

            return sum;
        }


    }
}
