using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split().ToArray();

            string[] reverceInput = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                reverceInput[i] = input[input.Length - 1 - i];
                Console.Write(reverceInput[i] + " ");
            }
        }
    }
}
