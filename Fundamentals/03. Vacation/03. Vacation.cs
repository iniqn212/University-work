using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string typeOfVacantioners = Console.ReadLine();
            string day = Console.ReadLine();

            double totalPrice = 0;

            if (day == "Friday")
            {
                if (typeOfVacantioners == "Students")
                {
                    totalPrice = numberOfPeople * 8.45;
                }
                else if (typeOfVacantioners == "Business")
                {
                    totalPrice = numberOfPeople * 10.90;
                }
                else if (typeOfVacantioners == "Regular")
                {
                    totalPrice = numberOfPeople * 15;
                }
            }
            else if (day == "Saturday")
            {
                if (typeOfVacantioners == "Students")
                {
                    totalPrice = numberOfPeople * 9.80;
                }
                else if (typeOfVacantioners == "Business")
                {
                    totalPrice = numberOfPeople * 15.60;
                }
                else if (typeOfVacantioners == "Regular")
                {
                    totalPrice = numberOfPeople * 20;
                }
            }
            else if (day == "Sunday")
            {
                if (typeOfVacantioners == "Students")
                {
                    totalPrice = numberOfPeople * 10.46;
                }
                else if (typeOfVacantioners == "Business")
                {
                    totalPrice = numberOfPeople * 16;
                }
                else if (typeOfVacantioners == "Regular")
                {
                    totalPrice = numberOfPeople * 22.50;
                }
            }
            if (typeOfVacantioners == "Students" && numberOfPeople >= 30)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
                Console.WriteLine($"Total price: {totalPrice:f2}");
            }
            else if (typeOfVacantioners == "Business" && numberOfPeople >= 100)
            {
                double discount = (totalPrice / numberOfPeople) * 10;
                totalPrice = totalPrice - discount;
                Console.WriteLine($"Total price: {totalPrice:f2}");

            }
            else if (typeOfVacantioners == "Regular" && numberOfPeople >= 10 && numberOfPeople <= 20)
            {
                totalPrice = totalPrice - (totalPrice * 0.05);
                Console.WriteLine($"Total price: {totalPrice:f2}");
            }
            else
            {
                Console.WriteLine($"Total price: {totalPrice:f2}");
            }
        }
    }
}
