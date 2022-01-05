using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double valueOfMoney = 0.0;
            double purchaseSum = 0.0;

            while (command != "Start")
            {
                double coins = double.Parse(command);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    valueOfMoney += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                command = Console.ReadLine();
            }
                command = Console.ReadLine();
           
            while (command != "End")
            {


                if (command == "Nuts")
                {
                    purchaseSum += 2.0;

                    if (valueOfMoney < purchaseSum)
                    {
                        purchaseSum -= 2.0;
                        Console.WriteLine("Sorry, not enough money");

                    }
                    else
                    {
                        Console.WriteLine("Purchased nuts");
                    }
                }
                else if (command == "Water")
                {
                    purchaseSum += 0.7;
                    if (valueOfMoney < purchaseSum)
                    {
                        purchaseSum -= 0.7;
                        Console.WriteLine("Sorry, not enough money");

                    }
                    else
                    {
                        Console.WriteLine("Purchased water");
                    }

                }
                else if (command == "Crisps")
                {
                    purchaseSum += 1.5;
                    if (valueOfMoney < purchaseSum)
                    {
                        purchaseSum -= 1.5;
                        Console.WriteLine("Sorry, not enough money");

                    }
                    else
                    {
                        Console.WriteLine("Purchased crisps");
                    }

                }
                else if (command == "Soda")
                {
                    purchaseSum += 0.8;
                    if (valueOfMoney < purchaseSum)
                    {
                        purchaseSum -= 0.8;
                        Console.WriteLine("Sorry, not enough money");

                    }
                    else
                    {
                        Console.WriteLine("Purchased soda");
                    }

                }
                else if (command == "Coke")
                {
                    purchaseSum += 1.0;
                    if (valueOfMoney < purchaseSum)
                    {
                        purchaseSum -= 1.0;
                        Console.WriteLine("Sorry, not enough money");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Purchased coke");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {Math.Abs(valueOfMoney - purchaseSum):f2}");
        }
    }
}
