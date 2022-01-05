using System;

namespace _004._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double firstGroup = 0;
            double secondGroup = 0;
            double thirdGroup = 0;
            double fourthGroup = 0;
            double fifthGroup = 0;

            for (int i = 1; i <= n; i++)
            {
                int curentNumber = int.Parse(Console.ReadLine());

                if (curentNumber < 200)
                {
                    firstGroup += 1;
                }
                else if (curentNumber >= 200 && curentNumber <= 399)
                {
                    secondGroup += 1;
                }
                else if (curentNumber >= 400 && curentNumber <= 599)
                {
                    thirdGroup += 1;
                }
                else if (curentNumber >= 600 && curentNumber <= 799)
                {
                    fourthGroup += 1;
                }
                else if (curentNumber > 790)
                {
                    fifthGroup += 1;
                }
            }
            Console.WriteLine($"{((firstGroup / n) * 100):f2}%");
            Console.WriteLine($"{((secondGroup / n) * 100):f2}%");
            Console.WriteLine($"{((thirdGroup / n) * 100):f2}%");
            Console.WriteLine($"{((fourthGroup / n) * 100):f2}%");
            Console.WriteLine($"{((fifthGroup / n) * 100):f2}%");
        }  
    }
}

