using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<string> num = new List<string>(numbers.Length);

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                string[] element = numbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                num.AddRange(element);
            }

            num.Select(int.Parse);

            Console.WriteLine(string.Join(" ", num));

        }
    }
}
