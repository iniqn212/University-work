using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToList();

            int wagonLimit = int.Parse(Console.ReadLine());

            while (true)
            {
                string[] command = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .ToArray();


                if (command[0] == "end")
                {
                    Console.WriteLine(String.Join(" ", wagons));
                    break;
                }

                if (command[0].ToLower() == "add")
                {
                    wagons.Add(int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int passengers = int.Parse(command[0]);
                        int allPassengers = wagons[i] + passengers;
                     

                        if (allPassengers <= wagonLimit)
                        {
                            wagons.RemoveAt(i);
                            wagons.Insert(i, allPassengers);
                            break;
                            
                        }
                       
                    }
                }
            }

        }
    }
}
