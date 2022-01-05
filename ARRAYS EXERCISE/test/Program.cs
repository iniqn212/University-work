using System;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());

            int curentSequenceSize = 1;
            int curentLowIndex = 0;
            int curentSum = 0;

            int bestSequenceSize = 0;
            int bestLowIndex = 0;
            int bestSum = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Clone them!")
                {
                    break;
                }

                int[] dna = command
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                foreach (int number in dna)
                {
                    curentSum += number;
                }

                for (int i = 0; i < dnaLength; i++)
                {
                    curentSequenceSize = 1;
                    int curentNumber = dna[i];

                    if (curentNumber == 0)
                    {
                        continue;
                    }
                   
                    for (int j = i + 1; j < dnaLength; j++)
                    {
                        if (curentNumber == dna[j])
                        {
                            curentSequenceSize++;                           
                        }
                        else
                        {
                            break;
                        } 
                    }

                    if (curentSequenceSize > bestSequenceSize)
                    {
                        bestSequenceSize = curentSequenceSize;
                        curentLowIndex = i;
                    }
                    else if (curentSequenceSize == bestSequenceSize)
                    {
                        if (curentLowIndex < bestLowIndex)
                        {
                            bestSequenceSize = curentSequenceSize;
                            curentLowIndex = i;
                        }
                        else if (curentLowIndex == bestLowIndex)
                        {
                            if (curentSum > bestSum)
                            {
                                bestSum = curentSum;
                                bestSequenceSize = curentSequenceSize;
                                curentLowIndex = i;
                            }
                        }
                    }                 
                }


            }

        }
    }
}
