using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] stockData = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string serialNumber = stockData[0];
                string itemName = stockData[1];
                int itemQuantity = int.Parse(stockData[2]);
                decimal itemPrice = decimal.Parse(stockData[3]);

              
                Box box = new Box();
                {
                    box.Item.Name = itemName;
                    box.Item.Price = itemPrice;
                    box.Serialnumber = serialNumber;
                    box.ItemQuantity = itemQuantity;
                    box.PriceForBox = itemQuantity * itemPrice;
                }
                boxes.Add(box);              
            }


            List<Box> sortedBox = boxes.OrderBy(boxes => boxes.PriceForBox).ToList();
            sortedBox.Reverse();

            foreach (Box box in sortedBox)
            {
                Console.WriteLine(box.Serialnumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }
        }
    }

}
