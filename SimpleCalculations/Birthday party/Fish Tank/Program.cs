using System;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int pastryChefs = int.Parse(Console.ReadLine());
          
            int cake = int.Parse(Console.ReadLine());
            int waffle = int.Parse(Console.ReadLine());
            int panCake = int.Parse(Console.ReadLine());

            int cakes = cake * 45;
            double waffles = waffle * 5.80;
            double panCakes = panCake * 3.20;
          
            double oneDay = (cakes + waffles + panCakes) * pastryChefs;
            double sum = oneDay * days;
           
            Console.WriteLine(sum - (sum / 8));
        }
    }
}
