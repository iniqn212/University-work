using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int lilyAge = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            double lilyMoney = 0;
            int lilyToys = 0;
            int stolenMoney = 0;
            int moneyPresent = 10;

            for (int i = 1; i <= lilyAge; i++)
            {
                if (i % 2 == 0)
                {
                    stolenMoney++;
                    lilyMoney += moneyPresent; 
                    moneyPresent += 10;
                }
                else
                {
                    lilyToys += 1;
                }
            }
             double moneyFromToys = lilyToys * toysPrice;
             double saveMoney = moneyFromToys + lilyMoney - stolenMoney;
             double difference = Math.Abs(saveMoney - washingMachinePrice);

             if (saveMoney >= washingMachinePrice)
             {
                 Console.WriteLine($"Yes! {difference:f2}");
             }
             else
             {
                 Console.WriteLine($"No! {difference:f2}");
             }
        }  
    }
}
