﻿using System;

namespace _06._Number_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number != 0)
            {
                if (number >= -100 && number <= 100)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                   Console.WriteLine("No");
                }
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
