using System;

namespace _03._Pastry_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int valueOfProduct = int.Parse(Console.ReadLine());
            int dayOfDecember = int.Parse(Console.ReadLine());

            

            double totalSum = 0.0;

            if (dayOfDecember <= 15)
            {
                if (product == "Cake")
                {
                    totalSum = 24 * valueOfProduct;
                }
                else if (product == "Souffle")
                {
                    totalSum = 6.66 * valueOfProduct;
                }
                else if (product == "Baklava")
                {
                    totalSum = 12.60 * valueOfProduct;
                }               
            }
            else if (dayOfDecember > 15)
            {
                if (product == "Cake")
                {
                    totalSum = 28.70 * valueOfProduct;
                }
                else if (product == "Souffle")
                {
                    totalSum = 9.80 * valueOfProduct;
                }
                else if (product == "Baklava")
                {
                    totalSum = 16.98 * valueOfProduct;
                }
            }

            if (dayOfDecember <= 22)
            {
                
                if (totalSum >= 100 && totalSum <= 200)
                {
                    totalSum *= 0.85;
                }
                else if (totalSum > 200)
                {
                    totalSum *= 0.75;
                }
                
                if (dayOfDecember <= 15)
                {
                    totalSum *= 0.90;
                }
            }
            Console.WriteLine($"{(totalSum):f2}");
        }
    }
}
