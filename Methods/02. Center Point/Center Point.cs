using System;

namespace _02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double pointA = double.Parse(Console.ReadLine());
            double pointB = double.Parse(Console.ReadLine());
            double pointAA = double.Parse(Console.ReadLine());
            double pointBB = double.Parse(Console.ReadLine());

            Console.WriteLine($"({string.Join(", ", CloserToZero(pointA, pointB, pointAA, pointBB))})");

        }

        private static double[] CloserToZero(double pointA, double pointB, double pointAA, double pointBB)
        {
            double firstPoint = Math.Abs(pointA) + Math.Abs(pointB);
            double secondPoint = Math.Abs(pointAA) + Math.Abs(pointBB);

            

            if (firstPoint <= secondPoint)
            {
                double[] closer = new double[] { pointA, pointB };
                return closer;
            }
            else
            {
                double[] closer = new double[] { pointAA, pointBB };

                return closer;
            }
        }
    }
}
