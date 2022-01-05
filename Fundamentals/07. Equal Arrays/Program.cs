using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputOne = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
           
            int[] inputTwo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            int checkIdentical = 0;
          
            if (inputOne.Length >= inputTwo.Length)
            {
                for (int i = 0; i < inputOne.Length; i++)
                {
                    if (inputOne[i] == inputTwo[i])
                    {
                        sum += inputOne[i];
                        
                    }
                    else
                    {
                        checkIdentical++;
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < inputTwo.Length; i++)
                {
                    if (inputTwo[i] == inputOne[i])
                    {
                        sum += inputOne[i];
                        
                    }
                    else
                    {
                        checkIdentical++;
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        break;
                    }
                }
            }
            if (checkIdentical == 0)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }            
        }
    }
}
