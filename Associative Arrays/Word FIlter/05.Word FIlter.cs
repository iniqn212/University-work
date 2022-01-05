using System;
using System.Linq;

namespace Word_FIlter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                string[] filter = words
                .Where(x => x.Length % 2 == 0)
                .ToArray();

            Console.WriteLine(string.Join("\n",filter));
        }
    }
}
