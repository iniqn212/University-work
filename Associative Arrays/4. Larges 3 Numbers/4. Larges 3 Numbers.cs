using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Larges_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] sorted = numbers
                .OrderByDescending( n => n  )
                .ToArray();

            for (int i = 0; i < 3; i++)
            {
                if (i >= sorted.Length)
                {
                    break;
                }
                Console.Write(sorted[i] + " ");
            }
        }
    }
}
