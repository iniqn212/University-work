using System;

namespace _04Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());

            double boatRent = 0;

            switch (season)
            {
                case "Spring":
                    boatRent = 3000;
                    if ( fishers <= 6)
                    {
                        boatRent = boatRent - (boatRent * 0.1);
                    }
                    else if (fishers > 6 && fishers <= 11)
                    {
                        boatRent = boatRent - (boatRent * 0.15);
                    }
                    else if (fishers > 12)
                    {
                        boatRent = boatRent - (boatRent * 0.25);
                    }
                    break;
                case "Summer":
                case "Autumn":
                    boatRent = 4200;
                    if (fishers <= 6)
                    {
                        boatRent = boatRent - (boatRent * 0.1);
                    }
                    else if (fishers > 6 && fishers <= 11)
                    {
                        boatRent = boatRent - (boatRent * 0.15);
                    }
                    else if (fishers > 12)
                    {
                        boatRent = boatRent - (boatRent * 0.25);
                    }
                    break;
                case "Winter":
                    boatRent = 2600;
                    if (fishers <= 6)
                    {
                        boatRent = boatRent - (boatRent * 0.1);
                    }
                    else if (fishers > 6 && fishers <= 11)
                    {
                        boatRent = boatRent - (boatRent * 0.15);
                    }
                    else if (fishers > 12)
                    {
                        boatRent = boatRent - (boatRent * 0.25);
                    }
                    break;
                default:
                    break;
            }
            if ( fishers % 2 == 0 && season != "Autumn")
            {
                boatRent = boatRent - (boatRent * 0.05);
            }
            if (budget >= boatRent)
            {
                Console.WriteLine($"Yes! You have {(budget - boatRent):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(boatRent - budget):f2} leva.");
            }
        }
    }
}
