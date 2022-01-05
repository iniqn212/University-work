using System;
using System.Globalization;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int lineOne = int.Parse(Console.ReadLine());
                int lineTwo = int.Parse(Console.ReadLine());
                GetMax(lineOne, lineTwo);
                Console.WriteLine(GetMax(lineOne , lineTwo));
            }
            else if (type == "char")
            {
                char lineOne = char.Parse(Console.ReadLine());
                char lineTwo = char.Parse(Console.ReadLine());
                GetMax(lineOne, lineTwo);
                char max = (char)GetMax(lineOne, lineTwo);
                Console.WriteLine(max);
            }
            else if (type == "string")
            {
                string lineOne = Console.ReadLine();
                string lineTwo = Console.ReadLine();
                GetMax(lineOne, lineTwo);
                Console.WriteLine(GetMax(lineOne, lineTwo));
            }


        }


        private static string GetMax(string lineOne, string lineTwo)
        {   
            int result = lineOne.CompareTo(lineTwo);

            if (result > 0)
            {
                return lineOne;
            }
            else if (result < 0 )
            {
                return lineTwo;
            }
            else
            {
                return lineOne;
            }
        }

        private static int GetMax( int lineOne, int lineTwo)
        {
            if (lineOne > lineTwo)
            {
                return lineOne;
            }
            else
            {
                return lineTwo;
            }
        }
    }
}
