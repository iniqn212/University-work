using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal inputPounds = decimal.Parse(Console.ReadLine());

            decimal onePoundInDollar = (decimal)1.31;

            decimal convertor = inputPounds * onePoundInDollar;

            Console.WriteLine($"{convertor:f3}");
        }
    }
}
