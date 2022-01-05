using System;
using System.Collections.Generic;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string text = input.ToLower();

            Vowels(text);

            int numbersOfVowels = int.Parse(Vowels(text));

            Console.WriteLine(numbersOfVowels);
        }

         static string Vowels(string text)
         {
            int count = 0;

            for (int i = 0; i <= text.Length - 1; i++)
            {
                char letter = text[i];

                switch (letter)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        count++;
                        break;
                    default:
                        break;
                }
            }
                return count.ToString();
         }
    }
}
