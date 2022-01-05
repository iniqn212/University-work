using System;

namespace _06Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {result} - odd");
                    }
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {result} - odd");
                    }
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {result} - odd");
                    }
                    break;
                case "/":
                    if (firstNumber == 0 || secondNumber == 0)
                    {
                        Console.WriteLine($"Cannot divide {firstNumber} by zero");
                    }
                    else
                    {
                        result = firstNumber / secondNumber;
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {result:f2}");
                    }
                    break;
                case "%":
                    if (firstNumber == 0 || secondNumber == 0)
                    {
                        Console.WriteLine($"Cannot divide {firstNumber} by zero");
                    }
                    else
                    {
                        result = firstNumber % secondNumber;
                        Console.WriteLine($"{firstNumber} % {secondNumber} = {result}");
                    }
                    break;

                default:
                    break;
            }

        }
    }
}
