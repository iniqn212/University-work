using System;

namespace _13._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string greats = Console.ReadLine();

            double price = 0;

            int nights = days - 1;

            if ( days < 10)
            {
                switch (room)
                {
                    case "room for one person":
                         price = nights * 18;
                        break;
                    case "apartment":
                        price = (nights * 25) - ((nights * 25) * 0.3);
                        break;
                    case "president apartment":
                        price = (nights * 35) - ((nights * 35) * 0.1);
                        break;

                    default:
                        break;
                }
            }
            else if (days >= 10 && days <= 15)
            {
                switch (room)
                {
                    case "room for one person":
                        price = nights * 18;
                        break;
                    case "apartment":
                        price = (nights * 25) - ((nights * 25) * 0.35);
                        break;
                    case "president apartment":
                        price = (nights * 35) - ((nights * 35) * 0.15);
                        break;

                    default:
                        break;
                }
            }
            else if (days > 15)
            {
                switch (room)
                {
                    case "room for one person":
                        price = nights * 18;
                        break;
                    case "apartment":
                        price = (nights * 25) - ((nights * 25) * 0.5);
                        break;
                    case "president apartment":
                        price = (nights * 35) - ((nights * 35) * 0.2);
                        break;

                    default:
                        break;
                }
            }
            if (greats == "positive")
            {
                Console.WriteLine($"{price + (price * 0.25):f2}");
            }
            else if (greats == "negative")
            {
                Console.WriteLine($"{price - (price * 0.1):f2}");
            }


        }
    }
}
