using System;

namespace _01Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfTicket = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            if (typeOfTicket == "Premiere")
            {
                Console.WriteLine($"{((rows * colums) * 12):f2} leva");
            }
            else if (typeOfTicket == "Normal")
            {
                Console.WriteLine($"{((rows * colums) * 7.5):f2} leva");
            }
            else if(typeOfTicket == "Discount")
            {
                Console.WriteLine($"{((rows * colums) * 5):f2} leva");
            }
        }
    }
}
