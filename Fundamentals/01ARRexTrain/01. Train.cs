using System;
using System.Linq;

namespace _01ARRexTrain
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numberOfWagons = int.Parse(Console.ReadLine());

            int[] travelers = new int[numberOfWagons];
            
            int sum = 0;

            for (int i = 0; i < numberOfWagons; i++)
            {
                travelers[i] = int.Parse(Console.ReadLine());
                sum += travelers[i];  
            }
            
            for (int i = 0; i < travelers.Length; i++)
            {
                Console.Write(travelers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
