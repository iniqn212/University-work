using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());
            
            if (sells >= 0 && sells <= 500)
            {
                switch (city)
                {
                    case "Sofia": Console.WriteLine($"{(sells * 0.05):f2}");
                        break;
                    case "Varna": Console.WriteLine($"{(sells * 0.045):f2}");
                        break;
                    case "Plovdiv": Console.WriteLine($"{(sells * 0.055):f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sells > 500 && sells <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine($"{(sells * 0.07):f2}");
                        break;
                    case "Varna":
                        Console.WriteLine($"{(sells * 0.075):f2}");
                        break;
                    case "Plovdiv":
                        Console.WriteLine($"{(sells * 0.08):f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sells > 1000 && sells <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine($"{(sells * 0.08):f2}");
                        break;
                    case "Varna":
                        Console.WriteLine($"{(sells * 0.1):f2}");
                        break;
                    case "Plovdiv":
                        Console.WriteLine($"{(sells * 0.12):f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sells > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine($"{(sells * 0.12):f2}");
                        break;
                    case "Varna":
                        Console.WriteLine($"{(sells * 0.13):f2}");
                        break;
                    case "Plovdiv":
                        Console.WriteLine($"{(sells * 0.145):f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
