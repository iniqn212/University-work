using System;

namespace _09._Moving_whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthFreeSpace = int.Parse(Console.ReadLine());
            int lenghtFreeSpace = int.Parse(Console.ReadLine());
            int heightFreeSpace = int.Parse(Console.ReadLine());
 
            double freeSpace = widthFreeSpace * lenghtFreeSpace * heightFreeSpace;
            int boxes = 0;
            

            while (true)
            {
                string input = Console.ReadLine();
                


                if (input == "Done")
                {
                    double leftSpace = freeSpace - boxes;
                    Console.WriteLine($"{leftSpace} Cubic meters left.");
                    break;
                }
                else if (boxes >= freeSpace)
                {
                    double needSpace = boxes - freeSpace;
                    Console.WriteLine($"No more free space! You need {needSpace} Cubic meters more.");
                    break;
                }
                else
                {
                    int cubes = int.Parse(input);
                    boxes += cubes;
                }
            }
        }
    }
}
