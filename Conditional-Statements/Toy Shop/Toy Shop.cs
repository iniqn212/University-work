using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double hollidayPrice = double.Parse(Console.ReadLine());
            int puzzleQty = int.Parse(Console.ReadLine());
            int speakingDollyQty = int.Parse(Console.ReadLine());
            int teddyBearQty = int.Parse(Console.ReadLine());
            int minnionsQty = int.Parse(Console.ReadLine());
            int trucksQty = int.Parse(Console.ReadLine());

            double puzzle = 2.60;
            int speackingDolly = 3;
            double teddyBear = 4.10;
            double minnion = 8.20;
            double truck = 2;

            double toysQty = (puzzleQty + speakingDollyQty + teddyBearQty + minnionsQty + trucksQty);
           
            double allToysPrice = (puzzle * puzzleQty) + (speackingDolly * speakingDollyQty) + (teddyBear * teddyBearQty) + (minnion * minnionsQty) + (truck * trucksQty);

            if (toysQty >= 50)
            {
                allToysPrice = allToysPrice - (allToysPrice * 0.25);
            }

            double afterRent = allToysPrice - (allToysPrice * 0.1);

            if ( afterRent >= hollidayPrice)
            {
                Console.WriteLine($"Yes! {afterRent - hollidayPrice:f2} lv left.");
            }
           else
            {
                Console.WriteLine($"Not enough money! {hollidayPrice - afterRent:f2} lv needed.");
            }
            
                
               
               
               
                 
            
                

                
          

        }
    }
}


            

            

