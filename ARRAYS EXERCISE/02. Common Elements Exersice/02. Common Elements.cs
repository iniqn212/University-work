using System;
using System.Linq;

namespace _02._Common_Elements_Exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] arrOne = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


            for (int i = 0; i < arrOne.Length ; i++)
            {
                for (int j = 0; j < arr.Length ; j++)
                {
                    if (arrOne[i] == arr[j])
                    {
                        Console.Write(arrOne[i] + " ");
                        
                    }
                }
            }
        }
    }
}
