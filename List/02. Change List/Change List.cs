using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
           
            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (command[0].ToLower() == "end")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                    break;
                }

                switch (command[0])
                {
                    case "Delete":
                        Remove(numbers, command);
                        break;
                    case "Insert":
                        Insert(numbers, command);
                        break;

                    default:
                        break;
                }
            }
        }

        private static List<int> Insert(List<int> numbers, string[] command)
        {
            int index = int.Parse(command[2]);
            int element = int.Parse(command[1]);

            numbers.Insert(index, element);

            return numbers;
        }

        private static List<int> Remove(List<int> numbers, string[] command)
        {
            int num = int.Parse(command[1]);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == num)
                {
                    numbers.RemoveAt(i);
                }
            }
            return numbers;
        }
    }
}
