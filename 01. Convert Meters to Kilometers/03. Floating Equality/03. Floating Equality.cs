using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNum = decimal.Parse(Console.ReadLine());
            decimal secondNum = decimal.Parse(Console.ReadLine());

            decimal eps = (decimal)0.000001;

            decimal difference = (decimal)Math.Abs(firstNum - secondNum);

            if (difference > eps)
            {
                Console.WriteLine("False");
            }
            else if (difference < eps)
            {
                Console.WriteLine("True" );
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
