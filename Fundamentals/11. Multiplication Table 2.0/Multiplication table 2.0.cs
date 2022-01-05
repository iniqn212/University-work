using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiple = int.Parse(Console.ReadLine());

            if (multiple > 10)
            {
                Console.WriteLine($"{number} X {multiple} = {number * multiple}");
            }
            else 
            {
                for (int i = multiple; i <= 10; i++)
                {
                    Console.WriteLine($"{number} X {i} = {number * i}");
                }
            }
        }
    }
}
