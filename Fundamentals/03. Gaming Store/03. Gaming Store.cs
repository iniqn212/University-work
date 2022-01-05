using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyBalance = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double spendMoney = 0;

            while (command != "Game Time")
            {
                if (command == "OutFall 4")
                {
                    if (moneyBalance >= 39.99)
                    {
                        spendMoney += 39.99;
                        moneyBalance -= 39.99;
                        Console.WriteLine($"Bought {command}");
                    }
                    else if (moneyBalance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    
                    if (moneyBalance <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
                else if (command == "CS: OG")
                {
                    if (moneyBalance >= 15.99)
                    {
                        spendMoney += 15.99;
                        moneyBalance -= 15.99;
                        Console.WriteLine($"Bought {command}");
                    }
                    else if (moneyBalance < 15.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }

                    if (moneyBalance <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
                else if (command == "Zplinter Zell")
                {
                    if (moneyBalance >= 19.99)
                    {
                        spendMoney += 19.99;
                        moneyBalance -= 19.99;
                        Console.WriteLine($"Bought {command}");
                    }
                    else if (moneyBalance < 19.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }

                    if (moneyBalance <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
                else if (command == "Honored 2")
                {
                    if (moneyBalance >= 59.99)
                    {
                        spendMoney += 59.99;
                        moneyBalance -= 59.99;
                        Console.WriteLine($"Bought {command}");
                    }
                    else if (moneyBalance < 59.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }

                    if (moneyBalance <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
                else if (command == "RoverWatch")
                {
                    if (moneyBalance >= 29.99)
                    {
                        spendMoney += 29.99;
                        moneyBalance -= 29.99;
                        Console.WriteLine($"Bought {command}");
                    }
                    else if (moneyBalance < 29.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }

                    if (moneyBalance <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
                else if (command == "RoverWatch Origins Edition")
                {
                    if (moneyBalance >= 39.99)
                    {
                        spendMoney += 39.99;
                        moneyBalance -= 39.99;
                        Console.WriteLine($"Bought {command}");
                    }
                    else if (moneyBalance < 39.99)
                    {
                        Console.WriteLine("Too Expensive");
                    }

                    if (moneyBalance <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                command = Console.ReadLine();
            }
            if (moneyBalance > 0)
            {
                Console.WriteLine($"Total spent: ${spendMoney:f2}. Remaining: ${moneyBalance:f2}");
            }
        }
    }
}
