using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumOne = int.Parse(Console.ReadLine());
            int inputNumTwo = int.Parse(Console.ReadLine());
            int inputNumThree = int.Parse(Console.ReadLine());

            sum(inputNumOne, inputNumTwo);

            int firstTwoDigits = sum(inputNumOne , inputNumTwo);

            Subtract(inputNumThree, firstTwoDigits);

            Console.WriteLine(Subtract(inputNumThree, firstTwoDigits));
        }

        private static int Subtract(int inputNumThree, int firstTwoDigits)
        {
            int sum = firstTwoDigits - inputNumThree;

            return sum;
        }


        private static int sum(int inputNumOne, int inputNumTwo)
        {
            int sum = inputNumOne + inputNumTwo;

            return sum;
        }
    }
}
