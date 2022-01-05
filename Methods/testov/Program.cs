using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("1");
            }
            else if (input == 2)
            {
                Console.WriteLine("1 1");
            }
            else
            {
                Tribonaci(input);
            }
            


        }

        private static void Tribonaci(int input)
        {
            int[] sequence = new int[input + 1];

            sequence[0] = 0;
            sequence[1] = 1;
            sequence[2] = 1;
            for (int i = 3; i < sequence.Length; i++)
            {
                sequence[i] = sequence[i - 2] + sequence[i - 1] + sequence[i - 3];
            }
            int[] fibonaci = new int[sequence.Length - 1];

            int index = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] != 0)
                {
                    fibonaci[index] = sequence[i];
                    index++;
                }
            }

            Console.Write(string.Join(" ",fibonaci));
        }
    }
}
