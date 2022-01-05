using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            MyMatrixMethod(input);
        }

        private static void MyMatrixMethod(int input)
        {
            for (int i = 0; i < input; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < input; j++)
                {
                    Console.Write(input + " ");
                }
            }
            return; 
        }
    }
}
