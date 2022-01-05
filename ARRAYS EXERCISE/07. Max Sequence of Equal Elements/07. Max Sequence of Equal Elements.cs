using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int counter = 1;
            int currentNumber = 0;

            int longesCounter = 1;
            int longesNumbers = arrayOfNumbers[0];


            for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
            {
                counter = 1;

                for (int j = i + 1; j < arrayOfNumbers.Length ; j++)
                {
                    if (arrayOfNumbers[i] == arrayOfNumbers[j])
                    {
                        counter++;
                        currentNumber = arrayOfNumbers[i];

                    }
                    else if (arrayOfNumbers[i] != arrayOfNumbers[j])
                    {
                                                                            
                        break;
                    }
                }

                if (counter > longesCounter)
                {
                    longesCounter = counter;
                    longesNumbers = currentNumber;
                    
                }     
            }
           
            for (int i = 0; i < longesCounter; i++)
            {
                Console.Write(longesNumbers + " ");
            }
        }
    }
}
