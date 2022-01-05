using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yeald = int.Parse(Console.ReadLine());

            double leftSpice = 0.0;
            int days = 0;

            while (yeald >= 100)
            {
                leftSpice = leftSpice + (yeald - 26);    
                yeald -= 10;
                days++;
            }
            if (days > 0)
            {
                leftSpice -= 26;
            }
            
            Console.WriteLine(days);
            Console.WriteLine(leftSpice);
        }
    }
}
