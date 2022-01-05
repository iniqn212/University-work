using System;

namespace _01._Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            double averageSpeed = double.Parse(Console.ReadLine());
            double litrePerHundredKm = double.Parse(Console.ReadLine());

            double allKm = 384400 * 2;
            double timeToTheMoonAndBack = Math.Ceiling(allKm / averageSpeed) + 3;
            double fuel = (litrePerHundredKm * allKm) / 100;

            Console.WriteLine(timeToTheMoonAndBack);
            Console.WriteLine(fuel);
        }
    }
}
