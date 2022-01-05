﻿using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double productQuantity = int.Parse(Console.ReadLine());

            totalOrderCosts(product, productQuantity);
        }

        private static void totalOrderCosts(string product, double productQuantity)
        {
            double price = 0.00;

            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{productQuantity * price:f2}");
        }
    }
}
