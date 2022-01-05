using System;

namespace _03._Vacation_whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            double needMoney = double.Parse(Console.ReadLine());
            double moneyInPoket = double.Parse(Console.ReadLine());

            int spendDaysCounter = 0;
            int DaysCounter = 0;
        

            while (true)
            {
                string action = Console.ReadLine();
                double dayMoney = double.Parse(Console.ReadLine());

                if (action == "spend")
                {
                    DaysCounter++;
                    spendDaysCounter++;
                    moneyInPoket -= dayMoney;

                    if (spendDaysCounter == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(DaysCounter);
                        break;
                    }
                  
                    if (moneyInPoket < 0)
                    {
                        moneyInPoket = 0;
                    }
                }
                else if (action == "save")
                {
                    DaysCounter++;
                    moneyInPoket += dayMoney;
                    spendDaysCounter = 0;
                    
                    if (moneyInPoket >= needMoney)
                    {
                        Console.WriteLine($"You saved the money for {DaysCounter} days.");
                        break;
                    }
                }
            }
        }
    }
}
