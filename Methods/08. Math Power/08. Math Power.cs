using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double powerNum = double.Parse(Console.ReadLine());

            MathPower(num, powerNum);

            Console.WriteLine(MathPower(num, powerNum));
        }

        private static double MathPower(double num, double powerNum)
        {
            double sum = Math.Pow(num, powerNum);

            return sum;
        }
    }
}
