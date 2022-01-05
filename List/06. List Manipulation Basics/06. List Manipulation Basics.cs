using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
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

                if (command[0] == "end")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                    break;
                }

                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        break;

                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        break;

                    case "RemoveAt":
                        int num = int.Parse(command[1]);
                        numbers.RemoveAt(num);
                        break;

                    case "Insert":
                        int element = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        numbers.Insert(index, element);
                        break;


                    default:
                        break;
                }
            }

            
        }
    }
}

