using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                int numberCopy = 0;

                int numbers = int.Parse(input);

                numberCopy = numbers;



                if (numberCopy == PalindromChecker(numbers))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        private static int PalindromChecker(int numOne)
        {
            int dig = 0;
            int rev = 0;
            while (numOne != 0)
            {
                dig = numOne % 10;
                rev = rev * 10 + dig;
                numOne = numOne / 10;
            }

            return rev;
        }
    }
}
