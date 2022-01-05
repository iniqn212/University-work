using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputOne = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> inputTwo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> mixedNum = new List<int>(inputTwo.Count + inputOne.Count);

            List<int> lastNum = new List<int>(mixedNum.Count);


            if (inputOne.Count > inputTwo.Count)
            {
                int firstBorder = inputOne[inputOne.Count - 2];
                int secondBorder = inputOne[inputOne.Count - 1];
                int j = inputTwo.Count - 1;

                for (int i = 0; i < inputTwo.Count; i++)
                {
                    mixedNum.Add(inputOne[i]);
                    mixedNum.Add(inputTwo[j]);
                    j--;
                }
                int startBorder = Math.Min(firstBorder, secondBorder);
                int endBorder = Math.Max(firstBorder, secondBorder);

                {
                    for (int i = 0; i < mixedNum.Count; i++)
                    {
                        if (mixedNum[i] > startBorder && mixedNum[i] < endBorder)
                        {
                            lastNum.Add(mixedNum[i]);
                        }
                    }
                }

                
            }
            else if (inputOne.Count < inputTwo.Count)
            {
                int firstBorder = inputTwo[0];
                int secondBorder = inputTwo[1];
                int j = inputTwo.Count - 1;

                for (int i = 0; i < inputOne.Count; i++)
                {
                    mixedNum.Add(inputOne[i]);
                    mixedNum.Add(inputTwo[j]);
                    j--;
                }
                int startBorder = Math.Min(firstBorder, secondBorder);
                int endBorder = Math.Max(firstBorder, secondBorder);

                {
                    for (int i = 0; i < mixedNum.Count; i++)
                    {
                        if (mixedNum[i] > startBorder && mixedNum[i] < endBorder)
                        {
                            lastNum.Add(mixedNum[i]);
                        }
                    }
                }

            }
            lastNum.Sort();
            Console.WriteLine(string.Join(" ",lastNum));
        }
    }
}
