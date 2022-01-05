using System;

namespace _05._Puppy_Care
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());

            dogFood *= 1000;
            int dogAte = 0;

            while (true)
            {
                
                string input = Console.ReadLine();

                if (input == "Adopted")
                {
                    if (dogFood >= dogAte)
                    {
                        Console.WriteLine($"Food is enough! Leftovers: {dogFood - dogAte} grams.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"Food is not enough. You need {dogAte - dogFood} grams more.");
                        return;
                    }
                }
                int feeding = int.Parse(input);
                dogAte += feeding;
            }       
        }
    }
}
