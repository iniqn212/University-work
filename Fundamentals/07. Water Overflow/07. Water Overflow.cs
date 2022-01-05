using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int allLitres = 0;
            int tankCapacity = 255;

            for (int i = 0; i < input; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                allLitres += litres;

                if (tankCapacity < allLitres)
                {
                    Console.WriteLine("Insufficient capacity!");
                    allLitres -= litres;
                }
            }
            Console.WriteLine(allLitres);
        }
    }
}
