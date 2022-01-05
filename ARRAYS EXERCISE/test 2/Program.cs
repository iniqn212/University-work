using System;

namespace test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(MyMethod(num));
        }

        static int MyMethod(int a , int b = 0)
        {
            int sum = (a + b);
            return sum;
        }
        
    }
}
