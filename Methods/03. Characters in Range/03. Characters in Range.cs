using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char charachterOne = char.Parse(Console.ReadLine());
                
            char charachterTwo = char.Parse(Console.ReadLine());

            int symbolOne = (int)charachterOne;
            int symbolTwo = (int)charachterTwo;

            

            List<int> Characters = new List<int>();
            
            Characters.AddRange(charNumbers(symbolOne, symbolTwo));

            foreach (var num in Characters)
            {
                Console.Write($"{(char)num} ");
            }
            

        }

        private static List<int> charNumbers(int symbolOne, int symbolTwo)
        {
            List<int> symbols = new List<int>();

            if (symbolOne < symbolTwo)
            {
                for (int i = symbolOne + 1; i < symbolTwo; i++)
                {
                    symbols.Add(i);
                }
            }
            else
            {
                for (int i = symbolTwo + 1; i < symbolOne; i++)
                {
                    symbols.Add(i);
                }
            }

            return symbols;
        }
    }
}
