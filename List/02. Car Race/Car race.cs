using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] number = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            double leftTime = 0.0;

            for (int i = 0; i < number.Length / 2; i++)
            {
                leftTime += number[i];

                if (number[i] == 0)
                {
                    leftTime *= 0.8;

                }

            }

            double rightTime = 0.0;

            for (int i = number.Length - 1; i > number.Length / 2; i--)
            {
                rightTime += number[i];

                if (number[i] == 0)
                {
                    rightTime *= 0.8;
                }
            }           


            if (leftTime < rightTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightTime}");
            }
        }
    }
}
