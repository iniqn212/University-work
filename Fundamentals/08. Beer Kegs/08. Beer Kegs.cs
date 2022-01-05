using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int limit = 0;

            string bigName = string.Empty;
            double bigKeg = 0.0;

            while (limit != input)
            {
                limit++;
                string nameOfKeg = Console.ReadLine();
                double radiousOfKeg = double.Parse(Console.ReadLine());
                int heightOfKeg = int.Parse(Console.ReadLine());

                double calculationOfSize = Math.Ceiling(Math.PI * (radiousOfKeg * radiousOfKeg) * heightOfKeg);
               

                if (calculationOfSize > bigKeg)
                {
                    bigKeg = calculationOfSize;
                    bigName = nameOfKeg;
                }
            }
            Console.WriteLine(bigName);
        }
    }
}
