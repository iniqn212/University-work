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

            int counter = 0;

            while (true)
            {
                string[] command = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();

                if (command[0] == "end")
                {
                    if (counter > 0)
                    {
                        Console.WriteLine(string.Join(" ", numbers));
                    }
                    break;
                }

                switch (command[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(command[1]));
                        counter++;
                        break;

                    case "Remove":
                        numbers.Remove(int.Parse(command[1]));
                        counter++;
                        break;

                    case "RemoveAt":
                        int num = int.Parse(command[1]);
                        numbers.RemoveAt(num);
                        counter++;
                        break;

                    case "Insert":
                        int element = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        numbers.Insert(index, element);
                        counter++;
                        break;
                    case "Contains":
                        if (numbers.Contains(int.Parse(command[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", Even(command, numbers)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", Odd(command, numbers)));
                        break;
                    case "GetSum":
                        Console.WriteLine(Sum(numbers));
                        break;
                    case "Filter":
                        Console.WriteLine(string.Join(" ", Condition(command, numbers)));
                        break;

                    default:
                        break;
                }
            }


        }
        private static bool IsListSame(List<int> cloneList, List<int> numbers)
        {
            int count = 0;


            if (count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static int Sum(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        private static List<int> Odd(string[] command, List<int> numbers)
        {
            List<int> odd = new List<int>(numbers.Count);


            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    odd.Add(numbers[i]);
                }
            }

            return odd;
        }

        private static List<int> Even(string[] command, List<int> numbers)
        {
            List<int> even = new List<int>(numbers.Count);

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even.Add(numbers[i]);
                }
            }

            return even;
        }

        private static List<int> Condition(string[] command, List<int> numbers)
        {
            List<int> afterFilter = new List<int>(numbers.Count);

            int condNum = int.Parse(command[2]);

            if (command[1] == "<")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < condNum)
                    {
                        afterFilter.Add(numbers[i]);
                    }
                }
            }
            else if (command[1] == "<=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= condNum)
                    {
                        afterFilter.Add(numbers[i]);
                    }
                }
            }
            else if (command[1] == ">")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > condNum)
                    {
                        afterFilter.Add(numbers[i]);
                    }
                }
            }
            else if (command[1] == ">=")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] >= condNum)
                    {
                        afterFilter.Add(numbers[i]);
                    }
                }
            }

            return afterFilter;
        }
    }
}

