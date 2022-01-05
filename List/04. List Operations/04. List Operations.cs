using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
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

                if (command[0] == "End")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                    break;
                }

                string function = command[0];
                var number = 0;

                bool IsItParse = int.TryParse(command[1], out int pars);
                if (IsItParse)
                {
                    number = int.Parse(command[1]);
                }
                /*else
                {
                     number = (string)command[1];
                }*/
                switch (function)
                {
                    case "Add":
                        numbers.Add(number);
                        break;

                    case "Insert":
                        int index = int.Parse(command[2]);

                        if (index < 0 || index > numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        numbers.Insert(index, number);
                        break;

                    case "Remove":
                        if (number < 0 || number > numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }                       
                        numbers.RemoveAt(number);
                        break;

                    case "Shift":
                        Shift(command, numbers);
                        break;

                    default:
                        break;
                }
            }

        }

        private static List<int> Shift(string[] command, List<int> numbers)
        {
            if (command[1] == "left")
            {
                int count = int.Parse(command[2]);

                for (int i = 0; i < count; i++)
                {
                    int firstElement = numbers[0];

                    numbers.RemoveAt(0);
                    numbers.Add(firstElement);
                }

            }
            else if (command[1] == "right")
            {
                int count = int.Parse(command[2]);

                for (int i = 0; i < count; i++)
                {
                    int lastElement = numbers[numbers.Count - 1];

                    numbers.Insert(0, lastElement);
                    numbers.RemoveAt(numbers.Count - 1);
                }

            }
            return numbers;

        }
    }
}
