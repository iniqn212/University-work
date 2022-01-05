using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] specialnumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bomb = specialnumbers[0];
            int power = specialnumbers[1];

            int bombIndex = 0;
            if (power != 0)
            {
                while (numbers.Contains(bomb))
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == bomb)
                        {
                            bombIndex = i;

                            explosion(numbers, bomb, bombIndex, power);
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == bomb)
                    {
                        numbers[i] = 0;
                    }
                }
            }



            int sumAfterDetonation = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sumAfterDetonation += numbers[i];
            }

            Console.WriteLine(sumAfterDetonation);
        }

        private static List<int> explosion(List<int> numbers, int bomb, int bombIndex, int power)
        {
            int bombRangeLeft = bombIndex - power;
            int bombRangeRight = bombIndex + power;

            if (bombRangeLeft >= 0 && bombRangeRight <= numbers.Count - 1)
            {
                for (int i = bombRangeLeft; i <= bombRangeRight; i++)
                {
                    numbers.RemoveAt(bombRangeLeft);
                }
            }
            else if (bombRangeLeft < 0 && bombRangeRight > numbers.Count - 1)
            {
                int count = numbers.Count - 1;
                for (int i = 0; i <= count; i++)
                {
                    numbers.RemoveAt(0);
                }
            }
            else if (bombRangeLeft < 0)
            {
                for (int i = 0; i <= bombRangeRight; i++)
                {
                    numbers.RemoveAt(0);
                }
            }
            else if (bombRangeRight > numbers.Count - 1)
            {
                int counter = numbers.Count - 1;

                for (int i = bombRangeLeft; i <= counter; i++)
                {
                    numbers.RemoveAt(bombRangeLeft);
                }
            }


            return numbers;
        }
    }
}
