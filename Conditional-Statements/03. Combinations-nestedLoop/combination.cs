using System;

namespace _03._Combinations_nestedLoop
{
    class combination
    {
        static void Main(string[] args)
        {
            int solution = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int a = 0; a <= solution; a++)
            {
                for (int b = 0; b <= solution; b++)
                {
                    for (int c = 0; c <= solution; c++)
                    {
                        if (a + b + c == solution)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
