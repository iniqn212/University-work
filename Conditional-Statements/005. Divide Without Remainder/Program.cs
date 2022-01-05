using System;

namespace _005._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double neutralGroup = 0;
            double firstGroup = 0;
            double secondGroup = 0;
            double thirdGroup = 0;

            for (int i = 1; i <= n; i++)
            {
                double curentNum = double.Parse(Console.ReadLine());

                if (curentNum % 2 != 0 && curentNum % 3 != 0 && curentNum % 4 != 0)
                {
                    neutralGroup += 1;
                }

                if (curentNum % 2 == 0)
                {
                    firstGroup += 1;
                }

                if (curentNum % 3 == 0)
                {
                    secondGroup += 1;
                }

                if (curentNum % 4 == 0)
                {
                    thirdGroup += 1;
                }
            }
            Console.WriteLine($"{((firstGroup / n) * 100):f2}%");
            Console.WriteLine($"{((secondGroup / n) * 100):f2}%");
            Console.WriteLine($"{((thirdGroup / n) * 100):f2}%");
        }
    }
}
