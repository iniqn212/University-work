using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = "";

            int totalStudent = 0;
            int totalStandart = 0;
            int totalKids = 0;

            while (action != "Finish")
            {
                action = Console.ReadLine();

                int student = 0;
                int standart = 0;
                int kids = 0;

                if (action == "Finish")
                {
                    break;
                }

                int freeSeats = int.Parse(Console.ReadLine());
               
                for (int currentSeat = 1; currentSeat <= freeSeats; currentSeat++)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "student")
                    {
                        student++;
                    }
                    else if (ticketType == "standard")
                    {
                        standart++;
                    }
                    else if (ticketType == "kid")
                    {
                        kids++;
                    }
                    else if (ticketType == "End")
                    {
                        break;
                    }
                }
                totalStudent += student;
                totalStandart += standart;
                totalKids += kids;

                Console.WriteLine($"{action} - {(((double)student + standart + kids) / 10) * 100:f2}% full.");
            }
            int totalTiket = totalKids + totalStandart + totalStudent;
            Console.WriteLine($"Total tickets: {totalTiket}");
            Console.WriteLine($"{(totalStudent / (double)totalTiket) * 100:f2}% student tickets.");
            Console.WriteLine($"{(totalStandart / (double)totalTiket) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(totalKids / (double)totalTiket) * 100:f2}% kids tickets.");
        }
    }
}
