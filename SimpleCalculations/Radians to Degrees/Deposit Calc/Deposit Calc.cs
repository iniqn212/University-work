using System;

namespace Deposit_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int periot = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());
            double sum = deposit + periot * (deposit * (interest / 100) / 12);
            Console.WriteLine(sum);
        }
    }
}
