using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> itemsByPrice = new Dictionary<string, decimal>();
            Dictionary<string, int> itemByQuantity = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "buy")
                {
                    break;
                }

                string[] productsInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string product = productsInfo[0];
                decimal price = decimal.Parse(productsInfo[1]);
                int quantity = int.Parse(productsInfo[2]);

                if (itemsByPrice.ContainsKey(product))
                {
                    itemByQuantity[product] += quantity;
                    itemsByPrice[product] = price;
                }
                else
                {
                    itemsByPrice.Add(product, price);
                    itemByQuantity.Add(product, quantity);
                }
            }

            /*  Dictionary<string, decimal> sortedProducts = itemsByPrice
                 .OrderByDescending(kvp => kvp.Value * itemByQuantity[kvp.Key])
                 .ToDictionary(x => x.Key , x => x.Value * itemByQuantity[x.Key]);

             foreach (var kvp in sortedProducts)
             {

                     Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
             }
           */

            foreach (var kvp in itemsByPrice)
            {
                string item = kvp.Key;
                decimal costs = kvp.Value;
                int quantity = itemByQuantity[item];

                decimal totalPrice = costs * quantity;

                Console.WriteLine($"{item} -> {totalPrice:f2}");
            }
        }
    }
}