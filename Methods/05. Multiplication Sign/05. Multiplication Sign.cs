using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            SignCheck(numOne, numTwo, numThree);
        }

        private static void SignCheck(int numOne, int numTwo, int numThree)
        {
            int negative = 0;
            int positive = 0;
            int zero = -1;

            if (numOne < 0)
            {
                negative++;
            }
            else if( numOne > 0)
            {
                positive++;
            }
            else
            {
                zero++;
            }
            if (numTwo < 0)
            {
                negative++;
            }
            else if (numTwo > 0)
            {
                positive++;
            }
            else
            {
                zero++;
            }
            if (numThree < 0)
            {
                negative++;
            }
            else if (numThree > 0)
            {
                positive++;
            }
            else
            {
                zero++;
            }

            if (zero > -1)
            {
                Console.WriteLine("zero");
            }
            else if (negative == 1 || negative == 3)
            {
                Console.WriteLine("negative");
            }
            else if (positive == 3 || positive == 1 || negative == 2 )
            {
                Console.WriteLine("positive");
            }
        }
    }
}
