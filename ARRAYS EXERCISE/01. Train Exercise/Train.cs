using System;

namespace _01._Train_Exercise
{
    class Train
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] wagons = new int[n];
            int travelers = 0;

            for (int i = 0; i < wagons.Length; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                travelers += wagons[i];
            }
            Console.WriteLine(String.Join(" ", wagons));
            Console.WriteLine(travelers);
        }
    }
}
