using System;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] info = input
                    .Split("/", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (info[0] == "Car")
                {


                    string type = info[0];
                    string brand = info[1];
                    string model = info[2];
                    int horsePower = int.Parse(info[3]);

                    catalogue.Car.Add(new Cars()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePower
                    });



                }
                else if (info[0] == "Truck")
                {
                    string type = info[0];
                    string brand = info[1];
                    string model = info[2];
                    int weight = int.Parse(info[3]);

                    catalogue.Truck.Add(new Trucks()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight
                    });
                }
            }

            if (catalogue.Car.Count > 0)
            {
                Console.WriteLine($"Cars:");
                foreach (Cars carList in catalogue.Car.OrderBy(car => car.Brand))
                {
                    Console.WriteLine($"{carList.Brand}: {carList.Model} - {carList.HorsePower}hp");
                }
            }

            if (catalogue.Truck.Count > 0)
            {
                Console.WriteLine($"Trucks:");
                foreach (Trucks truckList in catalogue.Truck.OrderBy(truck => truck.Brand))
                {
                    Console.WriteLine($"{truckList.Brand}: {truckList.Model} - {truckList.Weight}kg");
                }
            }
        }
    }

}
