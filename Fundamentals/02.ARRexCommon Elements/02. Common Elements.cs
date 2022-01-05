using System;
using System.Linq;

namespace _02.ARRexCommon_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputOne = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] inputTwo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < inputTwo.Length; i++)
            {
                string element = inputTwo[i];

                for (int j = 0; j < inputOne.Length; j++)
                {
                    if (element == inputOne[j])
                    {
                        Console.Write(inputOne[j] + " ");
                    }
                }
            }
        }
    }
}
