using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>
            {
                {"motes", 0},
                {"shards" , 0},
                {"fragments" , 0},
            };

            Dictionary<string, int> junk = new Dictionary<string, int>();

            bool IsEnough = false;
            string gettingItem = string.Empty;

            while (!IsEnough)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string elements = input[i + 1].ToLower();


                    if (items.ContainsKey(elements))
                    {
                        items[elements] += quantity;

                        if (items[elements] >= 250)
                        {
                            gettingItem = elements;
                            items[elements] -= 250;
                            IsEnough = true;
                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(elements))
                        {
                            junk[elements] += quantity;
                        }
                        else
                        {
                            junk.Add(elements, quantity);
                        }
                        
                    }
                }
            }

            if (gettingItem == "motes")
            {
                Console.WriteLine("Dragonwrath obtained!");
            }
            else if (gettingItem == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (gettingItem == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }

            Dictionary<string, int> sortedItems = items
                .OrderByDescending(i => i.Value)
                .ThenBy(i => i.Key)
                .ToDictionary(x => x.Key , x=> x.Value);
           
            Dictionary<string, int> sortedJunk = junk
                .OrderByDescending(i => i.Value)
                .ThenBy(i => i.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedItems)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            foreach (var kvp in sortedJunk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}