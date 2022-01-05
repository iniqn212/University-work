using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());


            for (int i = 1; i <= input; i++)
            {
                int curentNum = i;

           
                    int lastDigit = curentNum % 10;
                    curentNum = curentNum / 10;
                    int sum = lastDigit + curentNum;

                    if (sum == 5 || sum == 7 || sum == 11)
                    {
                        Console.WriteLine($"{i} -> True");
                    }
                    else
                    {
                        Console.WriteLine($"{i} -> False");
                    }
                
            }
        }
    }
}
