using System;

namespace _09._Chars_to_string
{
    class charstostring
    {
        static void Main(string[] args)
        {
            char inputOne = char.Parse(Console.ReadLine());
            char inputTwo = char.Parse(Console.ReadLine());
            char inputThree = char.Parse(Console.ReadLine());

            string combinated = inputOne.ToString() + inputTwo.ToString() + inputThree.ToString();

            Console.WriteLine(combinated);
        }
    }
}
