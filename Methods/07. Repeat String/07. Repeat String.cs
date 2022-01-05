using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeatNum = int.Parse(Console.ReadLine());

            RepeatableMethot(input, repeatNum);

            Console.WriteLine(RepeatableMethot(input, repeatNum));
        }

        private static string RepeatableMethot(string input, int repeatNum)
        {
            string merge = string.Empty;

            for (int i = 0; i < repeatNum; i++)
            {
                merge = merge + input;
            }

            return merge;
        }
    }
}
