using System;

namespace Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberrysPrice = double.Parse(Console.ReadLine());
            
            double qtyBananas = double.Parse(Console.ReadLine());
            double qtyPortocals = double.Parse(Console.ReadLine());
            double qtyRaspberrys = double.Parse(Console.ReadLine());
            double qtyStrawberrys = double.Parse(Console.ReadLine());

            double raspberrysPrice = strawberrysPrice * 0.5;
            double portocalsPrice = raspberrysPrice - (raspberrysPrice * 0.4);
            double bananasPrice = raspberrysPrice - (raspberrysPrice * 0.8);

            double raspberryMoney = qtyRaspberrys * raspberrysPrice;
            double portocalMoney = qtyPortocals * portocalsPrice;
            double bannanaMoney = qtyBananas * bananasPrice;
            double strawberryMoney = qtyStrawberrys * strawberrysPrice;

            double allMoney = raspberryMoney + portocalMoney + bannanaMoney + strawberryMoney;

            Console.WriteLine(Math.Round(allMoney,2));
        }
    }
}
