using System;

namespace _02.ARR_Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] number = new int[n];

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }

            int[] reverceNumber = new int[n];

            for (int i = 0; i < n; i++)
            {
                reverceNumber[i] = number[number.Length - 1 - i];
            }

            for (int i = 0; i < reverceNumber.Length; i++)
            {
                Console.Write($"{reverceNumber[i]} ");
            }  
        }               
    }
}


