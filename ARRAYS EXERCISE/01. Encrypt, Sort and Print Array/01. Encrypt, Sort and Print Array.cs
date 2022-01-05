using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            

            int[] script = new int[numberOfLines];

            for (int i = 0; i < numberOfLines; i++)
            {
                int sumVowel = 0;
                int sumConsonant = 0;

                string name = Console.ReadLine();
                string Glasni = "AaEeIiOoUu";

                for (int j = 0; j < name.Length; j++)
                {
                    if (Glasni.Contains(name[j]))
                    {
                        sumVowel = sumVowel + ((int)name[j] * name.Length);
                        
                    }
                    else
                    {
                        sumConsonant = sumConsonant + ((int)name[j] / name.Length);
                    }
                    
                }

                script[i] = sumConsonant + sumVowel;
            }
            Array.Sort(script);
            Console.WriteLine(string.Join("\n",script));
        }
    }
}
