using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal inputMeters = decimal.Parse(Console.ReadLine());

            decimal OneKilometerInMetter = 1000;

            decimal convertToKilometers = inputMeters / OneKilometerInMetter;

            Console.WriteLine($"{convertToKilometers:f2}");
        }
    }
}
