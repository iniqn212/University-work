using System;

namespace _003.Odd.Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double numbers = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum = evenSum + numbers;

                    if (numbers < evenMin)
                    {
                        evenMin = numbers;
                    }
                    
                   
                    if (numbers > evenMax)
                    {
                        evenMax = numbers;
                    }
                   
                }
                else if (i % 2 != 0)
                {
                    oddSum = oddSum + numbers;

                    if (numbers < oddMin)
                    {
                        oddMin = numbers;
                    }
                    
                   
                    if (numbers > oddMax)
                    {
                        oddMax = numbers;
                    }
                    
                }

            }
            Console.WriteLine($"OddSum={oddSum:f2},");
           
            if (oddMin != double.MaxValue)
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            else
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }
            

            Console.WriteLine($"EvenSum={evenSum:f2},");
           
            if (evenMin != double.MaxValue)
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
            else
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
           
        }
    }
}
