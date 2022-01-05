using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)     
               .ToArray();

            Dictionary<string, int> data = new Dictionary<string, int>();

            foreach (var item in input)
            {
                string word = item.ToLower();
              
                if (data.ContainsKey(word))
                {
                    data[word]++;
                }
                else
                {
                    data.Add(word, 1);
                }
            }

            foreach (var item in data)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
