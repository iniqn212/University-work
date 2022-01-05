using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lineOne = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList(); 
            List<int> lineTwo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int largeList = Math.Max(lineTwo.Count, lineOne.Count);
            List<int> mergeNumbers = new List<int>(lineOne.Count + lineTwo.Count);

            for (int i = 0; i < largeList; i++)
            {
                if (i < lineOne.Count)
                {
                    mergeNumbers.Add(lineOne[i]);
                }
                if (i < lineTwo.Count)
                {
                    mergeNumbers.Add(lineTwo[i]);
                }  
            }
            Console.WriteLine(string.Join(" ",mergeNumbers));
        }
    }
}
