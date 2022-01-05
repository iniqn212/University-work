﻿using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                if (input == "END")
                {
                    break;
                }
                dataTypeCheck(input);

                input = Console.ReadLine();
            }

        }

        private static void dataTypeCheck(string input)
        {
            if (int.TryParse(input, out int num))
            {
                Console.WriteLine($"{input} is integer type");
            }
            else if (double.TryParse(input, out double number))
            {
                Console.WriteLine($"{input} is floating point type");
            }
            else if (bool.TryParse(input, out bool check))
            {
                Console.WriteLine($"{input} is boolean type");
            }
            else if (char.TryParse(input, out char simbol))
            {
                Console.WriteLine($"{input} is character type");
            }
            else
            {
                Console.WriteLine($"{input} is string type");
            }
        }
    }
}
