﻿using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;


            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("{0}", 2 * i - 1);

                sum += 2 * i - 1;
            }
            Console.WriteLine("Sum: {0}",sum);
        }
    }
}
