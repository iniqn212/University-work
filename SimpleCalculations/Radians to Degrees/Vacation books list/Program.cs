using System;

namespace Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentPages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double bookHours = currentPages / pagesPerHour;
            double hours = bookHours / days;

            Console.WriteLine(hours);
        }
    }
}
