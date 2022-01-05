using System;

namespace _08Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
             string year = Console.ReadLine();
              double celebrates = double.Parse(Console.ReadLine());
              double weekendsGoHome = double.Parse(Console.ReadLine());
            double a = 3;
            double b = 4;
            double c = 2;
            double d = 3;
              double weekendInSofia = 48 - weekendsGoHome;
              double playInSofia = weekendInSofia * (a / b);
              double celebratePlay = celebrates * (c / d);

              double totalPlay = playInSofia + celebratePlay + weekendsGoHome;

              if (year == "leap")
              {
                  totalPlay = totalPlay + (totalPlay * 0.15);
              }

              Console.WriteLine(Math.Floor(totalPlay));
            
        }
    }
}