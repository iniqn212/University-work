using System;

namespace _04._Sum_of_Two_Numbers_nestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secodNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int a = firstNumber; a <= secodNumber; a++)
            {
                for (int b = firstNumber; b <= secodNumber; b++)
                {
                    counter++;
                    if (a + b == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({a} + {b} = {magicNumber})");
                        return;
                    }
                    
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
