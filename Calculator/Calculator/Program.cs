using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsPercent = false;

            Console.WriteLine("\t\t\tCalculator\r");
            Console.WriteLine("\t\t\t<><><><><>\r");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Would you like to use % ?: (y/n)");
            char confirmation = char.Parse(Console.ReadLine());
                
           IsPercent =  confirmation = y?true:false;
            
                



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

            Console.ReadLine();
        }
    }
}