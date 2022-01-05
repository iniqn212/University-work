using System;

namespace _06._Reversed_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirthChar = char.Parse(Console.ReadLine());

            Console.WriteLine($"{thirthChar} {secondChar} {firstChar}");
        }
    }
}
