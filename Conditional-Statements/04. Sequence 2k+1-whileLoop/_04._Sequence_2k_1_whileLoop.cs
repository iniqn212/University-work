using System;

namespace _04._Sequence_2k_1_whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int number = 1;

            while (n >= number)
            {
                Console.WriteLine(number);
                number = (number * 2) + 1;
            }
        }
    }
}
