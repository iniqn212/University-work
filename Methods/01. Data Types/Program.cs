using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            WhatisItXaXa(command);
        }

        private static void WhatisItXaXa(string command)
        {
            int num = 0;
            double number = 0.0;

            bool IsIntiger = int.TryParse(command, result: out num);
            if (IsIntiger)
            {
                
                int input = int.Parse(Console.ReadLine());
                int sum = input * 2;
                Console.WriteLine(sum);
            }
            bool IsDouble = double.TryParse(command, result: out number);
            if (IsDouble)
            {
                double input = double.Parse(Console.ReadLine());
                double sum = input * 1.5;
                Console.WriteLine(sum);
            }
            if (command == "string")
            {
                Console.WriteLine($"${command}$");
            }
            
        }
    }
}
