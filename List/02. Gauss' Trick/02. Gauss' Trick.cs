using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse)
                 .ToList();
            if (numbers.Count % 2 == 0)
            {
                for (int i = 0; i <= numbers.Count / 2; i++)
                {
                    numbers[i] = (int)numbers[i] + numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);

                }
            }
            else
            {
                for (int i = 0; i < numbers.Count / 2; i++)
                {
                    numbers[i] = (int)numbers[i] + numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);

                }
            }
            
            Console.WriteLine(String.Join(" ",numbers));
        }
        
    }
}
