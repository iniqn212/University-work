﻿using System;

namespace Sum_Seconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int sumTime = firstTime + secondTime + thirdTime;

            int minutes = sumTime / 60;
            int seconds = sumTime % 60;
             
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
                Console.WriteLine($"{minutes}:{seconds}");

        }
    }
}
