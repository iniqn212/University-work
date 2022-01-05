using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MiddPartOfString(input);
            
            Console.WriteLine(MiddPartOfString(input));
        }

        private static string MiddPartOfString(string input)
        {
            string result = string.Empty;

            if (input.Length % 2 == 0)
            {
                result = input[(input.Length / 2) - 1] + input[(input.Length / 2)].ToString();
            }
            else if (input.Length % 2 != 0)
            {
                result = input[input.Length / 2].ToString();
            }
            return result;
        }
    }
}
