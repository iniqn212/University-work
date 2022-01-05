using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double valueOfMoney = double.Parse(Console.ReadLine());
            double students = int.Parse(Console.ReadLine());
            double priceOfSabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBetls = double.Parse(Console.ReadLine());

            double freeBelts = Math.Floor(students / 6 );
            double sabersCount = Math.Ceiling(students * 1.1);

            double sabersCosts = sabersCount * priceOfSabers;
            double robesCosts = students * priceOfRobes;
            double beltsCosts = (students - freeBelts) * priceOfBetls;

            double curentCosts = sabersCosts + robesCosts + beltsCosts;

            if (curentCosts <= valueOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {curentCosts:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {curentCosts - valueOfMoney:f2}lv more.");
            } 
        }
    }
}
