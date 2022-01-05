using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double areaSquare = side * side;

                Console.WriteLine($"{areaSquare:f3}");
            }

            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double areaRectangle = sideA * sideB;

                Console.WriteLine($"{areaRectangle:f3}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double areaCircle = Math.PI * (radius * radius);

                Console.WriteLine($"{areaCircle:f3}");
            }
            else if (figure == "triangle")
            {
                double arm1 = double.Parse(Console.ReadLine());
                double arm2 = double.Parse(Console.ReadLine());
                double areaTriangle = ((arm1 * arm2) / 2);

                Console.WriteLine($"{areaTriangle:f3}");
            }
        }
    }
}
