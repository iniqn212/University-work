using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                int leftSide = int.Parse(Console.ReadLine());
                leftSum = leftSum + leftSide;
            }
            for (int i = 0; i < n; i++)
            {
                int rightSide = int.Parse(Console.ReadLine());
                rightSum = rightSum + rightSide;
            }
            if (rightSum == leftSum)
            {
                Console.WriteLine($" Yes, sum = {leftSum}");
            }
            else
            {
                int difference = Math.Abs(leftSum - rightSum);
                Console.WriteLine($" No, diff = {difference}");
            }

        }
    }
}
