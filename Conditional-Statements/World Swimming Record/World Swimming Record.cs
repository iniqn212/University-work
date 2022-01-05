using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double oneMeterDistance = double.Parse(Console.ReadLine());

            double lag = (Math.Floor(distance / 15) * 12.5);
            double ivanTime = ((distance * oneMeterDistance) + lag);

            if (ivanTime < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivanTime:f2} seconds.");
            }
            else
            {
                double neededSeconds = ivanTime - worldRecord;
                Console.WriteLine($"No, he failed! He was {neededSeconds:f2} seconds slower.");
            }


        }
    }
}
