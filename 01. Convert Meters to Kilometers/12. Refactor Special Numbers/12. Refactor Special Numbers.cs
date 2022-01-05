using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRange = int.Parse(Console.ReadLine());
            
            
            
            
            bool isSpecial = true;
            
            for (int i = 1; i <= numberRange; i++)
            {
                int sum = 0;
                int temp = i;

                while (temp > 0)
                {
                    sum += temp % 10;
                    temp = temp / 10;   
                }
                if (isSpecial = (sum == 5) || (sum == 7) || (sum == 11))
                {
                    Console.WriteLine("{0} -> {1}", i, isSpecial);
                }
                else
                {
                    isSpecial = false;
                    Console.WriteLine("{0} -> {1}", i, isSpecial);
                }                  
            }

        }
    }
}
