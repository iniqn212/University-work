using System;

namespace _02._Beer_And_Chips
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beers = int.Parse(Console.ReadLine());
            int chips = int.Parse(Console.ReadLine());

            double beerPrice = beers * 1.20;
            double chipsPrice = Math.Ceiling((beerPrice * 0.45) * chips);

            double total = beerPrice + chipsPrice;

            if (budget >= (total))
            {
                Console.WriteLine($"{name} bought a snack and has {budget - (beerPrice + chipsPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {(total - budget):f2} more leva!");
            }
            
        }
    }
}
