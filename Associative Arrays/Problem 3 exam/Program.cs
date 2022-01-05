using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            var heroes = new SortedDictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "End")
                {
                    break;
                }

                if (input[0] == "Enroll")
                {
                    if (!heroes.ContainsKey(input[1]))
                    {
                        heroes.Add(input[1], new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{input[1]} is already enrolled.");
                    }
                }
                else if (input[0] == "Learn")
                {
                    if (!heroes.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} doesn't exist.");
                    }
                    else if (heroes[input[1]].Contains(input[2]))
                    {
                        Console.WriteLine($"{input[1]} has already learnt {input[2]}.");
                    }
                    else
                    {
                        heroes[input[1]].Add(input[2]);
                    }
                }
                else if (input[0] == "Unlearn")
                {
                    if (!heroes.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} doesn't exist.");
                    }
                    else if (!heroes[input[1]].Contains(input[2]))
                    {
                        Console.WriteLine($"{input[1]} doesn't know {input[2]}.");
                    }
                    else
                    {
                        heroes[input[1]].Remove(input[2]);
                    }
                }
            }

            if (heroes.Count > 0)
            {
                Console.WriteLine("Heroes:");
                foreach (var hero in heroes.OrderByDescending(x => x.Value.Count))
                {
                    Console.WriteLine($"== {hero.Key}: {string.Join(" ", hero.Value)}");
                }
            }
        }
    }
}