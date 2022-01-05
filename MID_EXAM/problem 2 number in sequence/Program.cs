using System;
using System.Collections.Generic;
using System.Linq;

namespace problem_2_number_in_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> number = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0] != "Finish")
            {
                if (command[0] == "Add")
                {
                    number.Add(int.Parse(command[1]));
                }

                if (command[0] == "Remove")
                {
                    if (number.Contains(int.Parse(command[1])))
                    {
                        number.Remove(int.Parse(command[1]));
                    }
                }

                if (command[0] == "Replace")
                {
                    int index = number.FindIndex(number => number == int.Parse(command[1]));
                    number.Remove(int.Parse(command[1]));
                    number.Insert(index, int.Parse(command[2]));
                }

                if (command[0] == "Collapse")
                {
                    for (int i = 0; i < number.Count; i++)
                    {
                        if (i < int.Parse(command[1]))
                        {
                            number.Remove(number[i]);
                        }
                    }
                }

                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

               
            }

            Console.WriteLine(string.Join(" ", number));
        }
    }
}
