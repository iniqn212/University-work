using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int num = int.Parse(Console.ReadLine());

            for (int j = 0; j < num; j++)
            {
                
                int temp = array[0];

                for (int i = 0; i < array.Length - 1; i++)
                {   
                    array[i] = array[i + 1];
                }
                array[array.Length - 1] = temp;
            }
            Console.WriteLine(String.Join(" ", array));
        }
    }
}
