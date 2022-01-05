using System;

namespace _07Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double priceApartament = 0;
            double priceStudio = 0;

            switch (month)
            {
                case "May":
                case "October":
                    priceApartament = days * 65;
                    priceStudio = days * 50;
                    if (days > 7 && days < 14)
                    {
                        priceStudio = priceStudio - (priceStudio * 0.05);
                    }
                    else if ( days >14)
                    {
                        priceApartament = priceApartament - (priceApartament * 0.1);
                        priceStudio = priceStudio - (priceStudio * 0.3);
                    }
                    break;
                case "June":
                case "September":
                    priceApartament = days * 68.70;
                    priceStudio = days * 75.20;
                    if ( days > 14)
                    {
                        priceStudio = priceStudio - (priceStudio * 0.2);
                        priceApartament = priceApartament - (priceApartament * 0.1);
                    }
                    break;
                case "July":
                case "August":
                    priceApartament = days * 77;
                    priceStudio = days * 76;
                    if (days > 14)
                    {
                        priceApartament = priceApartament - (priceApartament * 0.1);
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Apartment: {priceApartament:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
        }  
    }
}
