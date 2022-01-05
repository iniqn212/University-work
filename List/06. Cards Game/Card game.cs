using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondDeck = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            if (firstDeck.Count > secondDeck.Count)
            {
                int difference = firstDeck.Count - secondDeck.Count;

                for (int i = 0; i < difference; i++)
                {
                    secondDeck.Add(0);
                }
            }
            else if (firstDeck.Count < secondDeck.Count)
            {
                int difference = secondDeck.Count - firstDeck.Count;

                for (int i = 0; i < difference; i++)
                {
                    firstDeck.Add(0);
                }
            }

            while (secondDeck.Sum() != 0 && firstDeck.Sum() != 0)
            {
                if (firstDeck[0] > secondDeck[0])
                {
                    firstDeck.Add(firstDeck[0]);
                    firstDeck.Add(secondDeck[0]);
                }
                else if (firstDeck[0] < secondDeck[0])
                {
                    secondDeck.Add(secondDeck[0]);
                    secondDeck.Add(firstDeck[0]);
                }             

                firstDeck.RemoveAt(0);
                secondDeck.RemoveAt(0);             
            }

            if (firstDeck.Sum() > secondDeck.Sum())
            {
                Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
            }
        }
    }
}
