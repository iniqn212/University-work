using System;

namespace _03New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int qtyOfFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double flowersPrice = 0;

            if (typeOfFlowers == "Roses")
            {
                if (qtyOfFlowers > 80)
                {
                    flowersPrice = ((qtyOfFlowers * 5) - ((qtyOfFlowers * 5) * 0.1));
                }
                else
                {
                    flowersPrice = qtyOfFlowers * 5;
                }
            }
            else if (typeOfFlowers == "Dahlias")
            {
                if (qtyOfFlowers > 90)
                {
                    flowersPrice = ((qtyOfFlowers * 3.8) - ((qtyOfFlowers * 3.8) * 0.15));
                }
                else
                {
                    flowersPrice = qtyOfFlowers * 3.8;
                }
            }
            else if (typeOfFlowers == "Tulips")
            {
                if (qtyOfFlowers > 80)
                {
                    flowersPrice = ((qtyOfFlowers * 2.8) - ((qtyOfFlowers * 2.8) * 0.15));
                }
                else
                {
                    flowersPrice = qtyOfFlowers * 2.8;
                }

            }
            else if (typeOfFlowers == "Narcissus")
            {
                if (qtyOfFlowers < 120)
                {
                    flowersPrice = ((qtyOfFlowers * 3) + ((qtyOfFlowers * 3) * 0.15));
                }
                else
                {
                    flowersPrice = qtyOfFlowers * 3;
                }
            }
            else if ( typeOfFlowers == "Gladiolus")
            {
                if(qtyOfFlowers < 80)
                {
                    flowersPrice = ((qtyOfFlowers * 2.5) + ((qtyOfFlowers * 2.5) * 0.20));
                }
                else
                {
                    flowersPrice = qtyOfFlowers * 2.5;
                }
            }
            if ( budget >= flowersPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {qtyOfFlowers} {typeOfFlowers} and {(budget - flowersPrice):f2} leva left.");
            }
            else if ( budget < flowersPrice)
            {
                Console.WriteLine($"Not enough money, you need {(flowersPrice - budget):f2} leva more.");
            }


        }
    }
}