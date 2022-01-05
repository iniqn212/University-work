using System;

namespace problem_1_merry_puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodForMont = double.Parse(Console.ReadLine());
            double hayForMont = double.Parse(Console.ReadLine());
            double coverForMont = double.Parse(Console.ReadLine());
            double pigWeight = double.Parse(Console.ReadLine());

            double foodInGrams = foodForMont * 1000;
            double hayInGrams = hayForMont * 1000;
            double coverInGrams = coverForMont * 1000;
            double pigInGrams = pigWeight * 1000;

            int checker = 0;


            

            for (int i = 1; i <= 30; i++)
            {
                foodInGrams = foodInGrams - 300;

                if (foodInGrams <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    checker++;
                    break;
                }

                if (i % 2 == 0)
                {
                    hayInGrams = hayInGrams - (foodInGrams * 0.05);

                    if (hayInGrams <= 0)
                    {
                        Console.WriteLine("Merry must go to the pet store!");
                        checker++;
                        break;
                    }
                }
            }
            coverInGrams = (coverInGrams - ((pigInGrams / 3) * 10));

            if (checker == 0)
            {
                if (coverInGrams <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");

                }
                else
                {
                    Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(foodInGrams / 1000):f2}, Hay: {(hayInGrams / 1000):f2}, Cover: {(coverInGrams / 1000):f2}.");
                }
            }
            

            
        }
    }
}
