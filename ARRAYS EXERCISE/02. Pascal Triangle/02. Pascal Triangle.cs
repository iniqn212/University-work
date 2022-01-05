using System;
using System.Linq;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("1");

            if (rows == 1)
            {
                return;
            }

            int[] startingArray = new int[] { 1, 1 };
            Console.WriteLine(string.Join(" ", startingArray));

            if (rows == 2)
            {
                return;
            }
            else
            {
         
                for (int i = 0; i < startingArray.Length; i++)
                {
                    int[] pascalArray = new int[startingArray.Length + 1];
                    pascalArray[0] = 1;
                    pascalArray[pascalArray.Length - 1] = 1;

                    for (int j = 1; j < pascalArray.Length - 1; j++)
                    {
                        pascalArray[j] = startingArray[j - 1] + startingArray[j];
                    }
                   
                    Console.WriteLine(string.Join(" ", pascalArray));
                    startingArray = pascalArray.ToArray();
                    

                    if (pascalArray.Length == rows)
                    {
                        break;
                    }
                }
            }

            
        }
    }
}
