using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal savings = decimal.Parse(Console.ReadLine());

            List<int> drumSet = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> drum = drumSet               
                .ToList();

            List<int> prices = drumSet
                .Select(w => w*3)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Hit it again, Gabsy!")
                {                  
                    Console.WriteLine(string.Join(" ", drumSet));
                    Console.WriteLine($"Gabsy has {(savings):f2}lv.");
                    break;
                }

                int hitPower = int.Parse(input);

                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= hitPower;

                    if (drumSet[i] <= 0)
                    {
                        int price = prices[i];

                        if (price <= savings)
                        {
                            savings -= price;
                            drumSet[i] = drum[i];
                        }

                    }
                }

                for (int i = 0; i < drumSet.Count; i++)
                {
                    if (drumSet[i] <= 0)
                    {
                        drumSet.Remove(drumSet[i]);
                        prices.Remove(prices[i]);
                        drum.Remove(drum[i]);
                    }
                }
            }

        }
    }
}
