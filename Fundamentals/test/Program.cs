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

            int currentIndex = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                bool isBigger = true;

                for (int j = i + 1; j <= array.Length - 1; j++)
                {
                    if (array[i] < array[j])
                    {
                        isBigger = false;  
                        break;
                    }   
                }
                if (isBigger)
                {
                    currentIndex = i;
                    Console.Write(array[i] + " ");
                }
            }
            

        }
    }
}