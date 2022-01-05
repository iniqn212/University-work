using System;
using System.Linq;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirthNum = int.Parse(Console.ReadLine());

            Checker(firstNum , secondNum , thirthNum);

            Console.WriteLine(Checker(firstNum, secondNum, thirthNum));
        }

        private static int Checker(int firstNum , int secondNum , int thirthNum)
        {
            int result = 0;

            if (firstNum < secondNum && firstNum < thirthNum)
            {
                result = firstNum;
            }
            else if (secondNum < firstNum && secondNum < thirthNum)
            {
                result = secondNum;
            }
            else
            {
                result = thirthNum;
            }

            return result;
        }
    }
}


