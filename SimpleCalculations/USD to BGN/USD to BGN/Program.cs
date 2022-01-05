using System;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double Usd = double.Parse(Console.ReadLine());
            double Bgn = Usd * 1.79549;

            Console.WriteLine(Math.Round(Bgn, 2) + " lv.");

        }
    }
}
