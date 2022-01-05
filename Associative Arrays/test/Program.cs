using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\tCalculator\r");
            Console.WriteLine("\t\t\t<><><><><>\r");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Please enter the first number:   ");
            decimal firstNum = decimal.Parse(Console.ReadLine());

            Console.Write("Please enter one of the following operators -> ( + - * /):   ");
            string opertor = Console.ReadLine();

            Console.Write("Please enter the second number:   ");
            decimal secondNum = decimal.Parse(Console.ReadLine());

            decimal answer = 0;

            switch (opertor)
            {
                case "+":
                    answer = firstNum + secondNum;
                    break;
                case "-":
                    answer = firstNum - secondNum;
                    break;
                case "*":
                    answer = firstNum * secondNum;
                    break;
                case "/":
                    answer = firstNum / secondNum;
                    break;

                default:
                    Console.WriteLine("Invalid sesion!");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"\t\t\tResult: {firstNum}{opertor}{secondNum} = {answer}\r");

        }
    }
}