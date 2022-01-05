using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Random word = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int rdmWord = word.Next(words.Length);
                string temp = words[i];
                words[i] = words[rdmWord];
                words[rdmWord] = temp;
            }

            Console.WriteLine(string.Join("\n",words));
            
        }
    }
}
