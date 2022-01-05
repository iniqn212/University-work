using System;
using System.Linq;

namespace _03.ARRex_Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            
            int[] arrOne = new int[n];
            int[] arrTwo = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] arrInput = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int firstNum = arrInput[0];
                int secondNum = arrInput[1];

                if (i % 2 == 0)
                {
                    arrOne[i] = firstNum;
                    arrTwo[i]= secondNum;
                }
                else
                {
                    arrOne[i] = secondNum;
                    arrTwo[i] = firstNum;
                }
               
            }
            Console.Write(String.Join(" ",arrOne));
            Console.WriteLine();
            Console.Write(String.Join(" ",arrTwo));

        }
    }
}
