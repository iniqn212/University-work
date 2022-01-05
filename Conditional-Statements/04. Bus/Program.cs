using System;

namespace _04._Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPassengers = int.Parse(Console.ReadLine());
            int numberOfStops = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfStops; i++)
            {
                int passingerGoOut = int.Parse(Console.ReadLine());
                int passingerGoIn = int.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    numberOfPassengers = (numberOfPassengers + passingerGoIn + 2) - passingerGoOut;
                }
                else if (i % 2 == 0)
                {
                    numberOfPassengers = (numberOfPassengers + passingerGoIn) - (2 + passingerGoOut);
                }
            }
            Console.WriteLine($"The final number of passengers is : {numberOfPassengers}");
        }
    }
}
