using System;

namespace _06._Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLocation = int.Parse(Console.ReadLine());
           
            
            double miningGold = 0.0;

            for (int i = 0; i < numberOfLocation; i++)
            {
                double averageGoldMinig = double.Parse(Console.ReadLine());
                int dayOfMining = int.Parse(Console.ReadLine());

                for (int d = 0; d < dayOfMining; d++)
                {
                    double gold = double.Parse(Console.ReadLine());
                    miningGold += gold;  
                }
               
                if ((miningGold / dayOfMining) >= averageGoldMinig)
                {
                    Console.WriteLine($"Good job! Average gold per day: {(miningGold / dayOfMining):f2}.");
                    miningGold = 0;
                }
                else if ((miningGold / dayOfMining) < averageGoldMinig)
                {
                    Console.WriteLine($"You need {(averageGoldMinig - (miningGold / dayOfMining)):f2} gold.");
                    miningGold = 0;
                }
            }
 
        }
    }
}
