using System;

namespace Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int otherDogs = int.Parse(Console.ReadLine());

            double price = dogs * 2.5;
            int otherPrice = otherDogs * 4;

            Console.WriteLine((price + otherPrice) + " lv.");



        }
    }
}
