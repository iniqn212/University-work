using System;
using System.Linq;

namespace _10._LadyBugs
{
    class LadyBugs
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            bool[] field = new bool[fieldSize];

            int[] bugsOnField = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (var index in bugsOnField)
            {
                if (index < 0 || index >= field.Length)
                {
                    continue;
                }

                field[index] = true;
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] instruction = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int position = int.Parse(instruction[0]);
                string direction = instruction[1];
                int moveLength = int.Parse(instruction[2]);



                if (position < 0 || position >= field.Length || !field[position])
                {
                    continue;
                }

                field[position] = false;

                while (true)
                {

                    if (direction == "right")
                    {
                        position = position + moveLength;
                    }
                    else if (direction == "left")
                    {
                        position = position - moveLength;
                    }

                    if (position < 0 || position >= field.Length)
                    {
                        break;
                    }
                    else if (!field[position])
                    {
                        field[position] = true;
                        break;
                    }
                }

            }
            foreach (var cell in field)
            {
                if (cell)
                {
                    Console.Write($"1 ");
                }
                else if (!cell)
                {
                    Console.Write($"0 ");
                }
            }

        }
    }
}
