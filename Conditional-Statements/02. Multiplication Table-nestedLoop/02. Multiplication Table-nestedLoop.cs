using System;

namespace _02._Multiplication_Table_nestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int firstMultipler = 1; firstMultipler <= 10; firstMultipler++)
            {
                for (int secondMultipler = 1; secondMultipler <= 10; secondMultipler++)
                {
                    Console.WriteLine($"{firstMultipler} * {secondMultipler} = {firstMultipler * secondMultipler}");
                }
            }
        }
    }
}
