using System;
using System.Linq;

namespace _05.ARRexTop_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i <= array.Length - 1; i++)
            {

                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[i] > array[j] && array[i] > array[array.Length - 1])
                    {
                        Console.Write($"{array[i]} ");
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
               
        }
    }
}
