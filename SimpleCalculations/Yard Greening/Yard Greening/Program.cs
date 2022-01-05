using System;

namespace Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double sqm = double.Parse(Console.ReadLine());
            double result = sqm * 7.61;
            double endPrice = result * 0.18;
            Console.WriteLine("The final price is: " + (result - endPrice) + " lv.");
            Console.WriteLine("The discount is: " + ((result * 18) / 100) + " lv.");
        }
    }
}
