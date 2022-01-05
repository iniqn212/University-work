using System;

namespace _02Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degree = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            if(degree >= 10 && degree <= 18)
            {
                switch (time)
                {
                    case "Morning": Console.WriteLine($"It's {degree} degrees, get your {"Sweatshirt"} and {"Sneakers"}.");
                        break;
                    case "Afternoon": Console.WriteLine($"It's {degree} degrees, get your {"Shirt"} and {"Moccasins"}.");
                        break;
                    case "Evening": Console.WriteLine($"It's {degree} degrees, get your {"Shirt"} and {"Moccasins"}.");
                        break;

                    default:
                        break;
                }
            }
            else if (degree > 18 && degree <= 24)
            {
                switch (time)
                {
                    case "Morning":
                        Console.WriteLine($"It's {degree} degrees, get your {"Shirt"} and {"Moccasins"}.");
                        break;
                    case "Afternoon":
                        Console.WriteLine($"It's {degree} degrees, get your {"T-Shirt"} and {"Sandals"}.");
                        break;
                    case "Evening":
                        Console.WriteLine($"It's {degree} degrees, get your {"Shirt"} and {"Moccasins"}.");
                        break;

                    default:
                        break;
                }   
            }
            else if (degree >= 25)
            {
                    switch (time)
                    {
                        case "Morning":
                            Console.WriteLine($"It's {degree} degrees, get your {"T-Shirt"} and {"Sandals"}.");
                            break;
                        case "Afternoon":
                            Console.WriteLine($"It's {degree} degrees, get your {"Swim Suit"} and {"Barefoot"}.");
                            break;
                        case "Evening":
                            Console.WriteLine($"It's {degree} degrees, get your {"Shirt"} and {"Moccasins"}.");
                            break;

                        default:
                            break;
                    }
            
            }
        }
    }
}
