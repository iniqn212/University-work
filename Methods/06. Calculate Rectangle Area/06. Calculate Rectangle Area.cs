using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double rectangleSideA = double.Parse(Console.ReadLine());
            double rectangleSideB = double.Parse(Console.ReadLine());

            GetRectangleArea(rectangleSideA, rectangleSideB);

            Console.WriteLine(GetRectangleArea(rectangleSideA, rectangleSideB));
        }

        private static double GetRectangleArea(double rectangleSideA, double rectangleSideB)
        {
            double area = rectangleSideA * rectangleSideB;

            return area;
        }
    }
}
