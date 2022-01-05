using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] reverseNumbers = new int[n];

            for (int i = n - 1; i >= 0; i--)
            {
                reverseNumbers[i] = int.Parse(Console.ReadLine());
                
            }
            for (int i = 0; i < reverseNumbers.Length ; i++)
            {
                Console.Write(reverseNumbers[i] + " ");
            }
        }
    }
}
