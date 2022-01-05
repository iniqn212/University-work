using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double convertNumber = double.Parse(Console.ReadLine());
            string unit = Console.ReadLine();
            string exitUnit = Console.ReadLine();

            if (unit == "mm" && exitUnit == "cm")
            {
                Console.WriteLine($"{(convertNumber * 0.1):f3}");
            }
                
            else if ( unit == "mm" && exitUnit == "m")
            {
                Console.WriteLine($"{(convertNumber * 0.001):f3}");
            }
               
            else if (unit == "cm" && exitUnit == "mm")
            {
                Console.WriteLine($"{(convertNumber * 10):f3}");
            }
                
            else if ( unit == "cm" && exitUnit == "m")
            {
                Console.WriteLine($"{(convertNumber * 0.01):f3}");
            }
                
            else if ( unit == "m" && exitUnit == "mm")
            {
                Console.WriteLine($"{(convertNumber * 1000):f3}");
            }
            else if (unit == "m" && exitUnit == "cm")
            {
                Console.WriteLine($"{(convertNumber * 100):f3}");
            }
                
        }
    }
}
