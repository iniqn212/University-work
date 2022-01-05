using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double numberTwo = double.Parse(Console.ReadLine());

            MathOperations(numberOne, operation, numberTwo);

            Console.WriteLine($"{MathOperations(numberOne, operation, numberTwo)}");
        }

        private static double MathOperations(double numberOne, string operation, double numberTwo)
        {
            double sum = 0.0;

            switch (operation)
            {
                case "/":
                    sum = numberOne / numberTwo;
                    break;
                case "*":
                    sum = numberOne * numberTwo;
                    break;
                case "-":
                    sum = numberOne - numberTwo;
                    break;
                case "+":
                    sum = numberOne + numberTwo;
                    break;
                default:
                    break;
            }

            return sum;
        }
    }
}
