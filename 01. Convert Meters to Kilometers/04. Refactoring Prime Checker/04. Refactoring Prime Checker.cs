using System;
using System.Linq;

namespace _04._Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
           
            for (int i = 2; i <= input; i++)
            {
                bool isPrime = true;
                

                
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;

                        break;
                    }
                }
                if (isPrime == false)
                {
                    string isFalse = "false";
                    Console.WriteLine("{0} -> {1}", i, (isFalse));
                }
                else
                {
                    string isTrue = "true";
                    Console.WriteLine("{0} -> {1}", i, (isTrue));
                }
                
            }

        }
    }
}
