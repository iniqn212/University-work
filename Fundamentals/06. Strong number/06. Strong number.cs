using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int doublicateOfNumber = number;
            int sum = 0;

            while ((number > 0))
            {
                int currentNumber = number % 10;
                int facturiel = 1;

                for (int i = currentNumber; i >= 1; i--)
                {
                    facturiel *= i;
                }

                sum += facturiel;
                number /= 10;
            }
            if (sum == doublicateOfNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
