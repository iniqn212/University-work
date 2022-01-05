using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int num = Math.Abs(number);

            GetMultipleOfEvenAndOdds(num);

            Console.WriteLine(GetMultipleOfEvenAndOdds(num));
        }

        private static int GetMultipleOfEvenAndOdds(int num)
        {
            int sum = GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);

            return sum;
        }

        private static int GetSumOfOddDigits(int num)
        {
            int oddSum = 0;

            while (num != 0)
            {
                int lastDigit = 0;
                lastDigit = num % 10;
                if (lastDigit % 2 != 0)
                {
                    oddSum += lastDigit;
                }
                num = num / 10; 
            }

            return oddSum;
        }

        private static int GetSumOfEvenDigits(int num)
        {
            int evenSum = 0;

            while (num != 0)
            {
                int lastDigit = 0;
                lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }
                num = num / 10;
            }

            return evenSum;
        }
    }
}
