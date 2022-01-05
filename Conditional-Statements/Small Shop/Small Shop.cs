using System;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            string city = Console.ReadLine();
            double qty = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                switch (item)
                {
                    case "coffee":
                        Console.WriteLine(qty * 0.5);
                        break;
                    case "water":
                        Console.WriteLine(qty * 0.80);
                        break;
                    case "beer":
                        Console.WriteLine(qty * 1.20);
                        break;
                    case "sweets":
                        Console.WriteLine(qty * 1.45);
                        break;
                    case "peanuts":
                        Console.WriteLine(qty * 1.60);
                        break;

                    default:
                        break;
                }
            }
            else if (city == "Plovdiv")
            {
                switch (item)
                {
                    case "coffee":
                        Console.WriteLine(qty * 0.40);
                        break;
                    case "water":
                        Console.WriteLine(qty * 0.70);
                        break;
                    case "beer":
                        Console.WriteLine(qty * 1.15);
                        break;
                    case "sweets":
                        Console.WriteLine(qty * 1.30);
                        break;
                    case "peanuts":
                        Console.WriteLine(qty * 1.50);
                        break;
                    default:
                        break;
                }


            }
            else if (city == "Varna")
            {
                switch (item)
                {
                    case "coffee":
                        Console.WriteLine(qty * 0.45);
                        break;
                    case "water":
                        Console.WriteLine(qty * 0.70);
                        break;
                    case "beer":
                        Console.WriteLine(qty * 1.10);
                        break;
                    case "sweets":
                        Console.WriteLine(qty * 1.35);
                        break;
                    case "peanuts":
                        Console.WriteLine(qty * 1.55);
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
