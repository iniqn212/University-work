using System;

namespace _05_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = "";
            string typeOfHolliday = "";
            double spendMoney = 0;

            if (budget <= 100)
            {
                location = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        typeOfHolliday = "Camp";
                        spendMoney = budget * 0.3;
                        break;
                    case "winter":
                        typeOfHolliday = "Hotel";
                        spendMoney = budget * 0.7;
                        break;
                    default:
                        break;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                location = "Balkans";
                switch (season)
                {
                    case "summer":
                        typeOfHolliday = "Camp";
                        spendMoney = budget * 0.4;
                        break;
                    case "winter":
                        typeOfHolliday = "Hotel";
                        spendMoney = budget * 0.8;
                        break;
                    default:
                        break;
                }
            }
            else if (budget > 1000)
            {
                location = "Europe";
                typeOfHolliday = "Hotel";
                spendMoney = budget * 0.9;
            }
            Console.WriteLine($"Somewhere in {location}" );
            Console.WriteLine($"{typeOfHolliday} - {spendMoney:f2}");
        }
            
    }
}
