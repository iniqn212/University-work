using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                if (command[0] == "3:1")
                {
                    break;
                }



                if (command[0] == "merge")
                {
                    int startIdx = int.Parse(command[1]);
                    int endIdx = int.Parse(command[2]);

                    if (startIdx >= inputData.Count || endIdx < 0)
                    {
                        continue;
                    }

                    if (startIdx < 0)
                    {
                        startIdx = 0;
                    }

                    if (endIdx >= inputData.Count)
                    {
                        endIdx = inputData.Count - 1;
                    }

                    string mergeString = string.Empty;

                    for (int i = startIdx; i <= endIdx; i++)
                    {
                        string element = inputData[i];
                        mergeString += element;
                    }


                    int difference = endIdx - startIdx;
                    inputData.RemoveRange(startIdx, difference + 1);
                    inputData.Insert(startIdx, mergeString);
                }
                else
                {

                    int idx = int.Parse(command[1]);
                    int partition = int.Parse(command[2]);
                    string elements = inputData[idx];

                    inputData.RemoveAt(idx);

                    int partitionSize = elements.Length / partition;

                    List<string> substrings = new List<string>();

                    for (int i = 0; i < partition - 1; i++)
                    {
                        string substring = elements.Substring(i * partitionSize, partitionSize);
                        substrings.Add(substring);
                    }

                    string lastSubstring = elements.Substring((partition - 1) * partitionSize);
                    substrings.Add(lastSubstring);

                    inputData.InsertRange(idx, substrings);
                }

            }

            Console.WriteLine(string.Join(" ", inputData));

        }
    }
}
