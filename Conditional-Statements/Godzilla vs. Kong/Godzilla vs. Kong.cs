using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statisticians = int.Parse(Console.ReadLine());
            double dressPrice = double.Parse(Console.ReadLine());
           
            double decorPrice = budget * 0.1;
            double dressCosts = dressPrice * statisticians;
           
            if ( statisticians > 150)
            {
                dressCosts = dressCosts - (dressCosts * 0.1);
            }

            double costs = dressCosts + decorPrice;
           
            if ( costs > budget)
            {
                double needMoney = costs - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {needMoney:f2} leva more.");
            }
            else
            {
                double moneyLeft = budget - costs;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
        }
    }
   
}
