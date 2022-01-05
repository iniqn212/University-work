using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                if (command[0] == "end")
                {
                    Console.WriteLine($"[{string.Join(", ", number)}]");
                    break;
                }

                switch (command[0])
                {
                    case "exchange":
                        if (int.Parse(command[1]) < 0 || int.Parse(command[1]) > number.Length)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        number = Exchange(number, command);
                        break;

                    case "max":
                        int max = Max(number, command);

                        if (max == 0)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(max);
                        }
                        break;

                    case "min":
                        int min = Min(number, command);

                        if (min == int.MaxValue)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(min);
                        }
                        break;

                    case "first":
                        if (int.Parse(command[1]) < 0 || int.Parse(command[1]) > number.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            Console.WriteLine($"[{string.Join(", ", First(number, command))}]");
                        }
                        break;

                    case "last":
                        if (int.Parse(command[1]) < 0 || int.Parse(command[1]) > number.Length)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            int[] lastNum = Last(number, command);

                            if (lastNum.Length == int.Parse(command[1]))
                            {
                                Console.WriteLine($"[{string.Join(" ", lastNum)}]");
                            }
                            else
                            {
                                Console.WriteLine("[]");
                            }

                        }
                        break;

                    default:
                        break;
                }


            }
        }

        private static int[] Last(int[] number, string[] command)
        {
            int[] elements = new int[int.Parse(command[1])];
            int noMatch = 0;
            int[] matchNo = new int[0];

            if (command[2] == "odd")
            {
                int count = int.Parse(command[1]);

                for (int i = number.Length - 1; i >= 0; i--)
                {
                    int num = number[i];

                    if (count <= 0)
                    {
                        break;
                    }

                    if (num % 2 != 0)
                    {
                        elements[i] = num;
                        count--;
                    }
                    else
                    {
                        noMatch++;
                    }
                }
            }
            else if (command[2] == "even")
            {
                int count = int.Parse(command[1]);

                for (int i = number.Length - 1; i >= 0; i--)
                {
                    int num = number[i];

                    if (count <= 0)
                    {
                        break;
                    }

                    if (num % 2 == 0)
                    {
                        elements[i] = num;
                        count--;
                    }
                    else
                    {
                        noMatch++;
                    }
                }
            }
            if (noMatch == number.Length)
            {
                return matchNo;
            }
            else
            {
                return elements;
            }

        }

        private static int[] First(int[] number, string[] command)
        {
            int[] elements = new int[int.Parse(command[1])];
            int trueZeroCount = 0;

            if (command[2] == "odd")
            {
                int count = int.Parse(command[1]);

                for (int i = 0; i < number.Length; i++)
                {
                    int num = number[i];

                    if (count <= 0)
                    {
                        break;
                    }

                    if (num % 2 != 0)
                    {
                        elements[i] = num;
                        count--;
                    }
                }
            }
            else if (command[2] == "even")
            {
                int count = int.Parse(command[1]);

                for (int i = 0; i < number.Length; i++)
                {
                    int num = number[i];

                    if (count <= 0)
                    {
                        break;
                    }
                    if (num % 2 == 0)
                    {
                        if (number[i] == 0)
                        {
                            trueZeroCount++;
                        }

                        elements[i] = num;
                        count--;
                    }
                }

                if (count == int.Parse(command[1]))
                {
                    Console.WriteLine("[]");
                }
                else
                {

                }
            }

            return elements;
        }

        private static int Min(int[] number, string[] command)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            if (command[1] == "odd")
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] % 2 != 0)
                    {
                        if (number[i] <= min)
                        {
                            min = number[i];
                            minIndex = i;
                        }
                    }
                }
            }

            else if (command[1] == "even")
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] % 2 == 0)
                    {
                        if (number[i] <= min)
                        {
                            min = number[i];
                            minIndex = i;
                        }
                    }
                }
            }
            if (min == int.MaxValue)
            {
                return min;
            }
            else
            {
                return minIndex;
            }

        }

        private static int Max(int[] number, string[] command)
        {
            int max = 0;
            int maxIndex = 0;

            if (command[1] == "odd")
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] % 2 != 0)
                    {
                        if (number[i] > max)
                        {
                            max = number[i];
                            maxIndex = i;
                        }
                    }
                }
            }

            else if (command[1] == "even")
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] % 2 == 0)
                    {
                        if (number[i] > max)
                        {
                            max = number[i];
                            maxIndex = i;
                        }
                    }
                }
            }

            return maxIndex;
        }

        private static int[] Exchange(int[] number, string[] command)
        {
            int index = int.Parse(command[1]);

            int[] exchangedNum = new int[number.Length];

            int count = 0;
            for (int i = index + 1; i < number.Length; i++)
            {
                exchangedNum[count] = number[i];
                count++;
            }
            count = 0;
            for (int i = (exchangedNum.Length - 1) - index; i < exchangedNum.Length; i++)
            {
                exchangedNum[i] = number[count];
                count++;

            }

            number = exchangedNum;
            return number;
        }


    }
}
