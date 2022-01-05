using System;

namespace _06._Building_nestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int l = levels; l >= 1; l--)
            {
                for (int r = 0; r < rooms; r++)
                {
                    if (l == levels)
                    {
                        Console.Write($"L{l}{r} ");
                    }
                    else if (l % 2 == 0)
                    {
                        Console.Write($"O{l}{r} ");
                    }
                    else if (l % 2 != 0)
                    {
                        Console.Write($"A{l}{r} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
