using System;

namespace _05._Account_Balance_whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string increase = Console.ReadLine();
            double totalMoney = 0;
            

            while (increase != "NoMoreMoney")
            {
                double money = double.Parse(increase);  // for double check 

                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");       
                    break;
                }
                
                    totalMoney += money;
                    Console.WriteLine($"Increase: {money:f2}");
                increase = Console.ReadLine();

                
            }
            Console.WriteLine($"Total: {totalMoney:f2}");
        }
        
    }
}
