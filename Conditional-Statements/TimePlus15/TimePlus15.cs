using System;

namespace TimePlus15
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (hour >= 0 && hour <= 23)
            {

            }
            else
            {
                Console.WriteLine("incorect hour");
            }

            if (minutes >= 0 && minutes <= 59)
            {

            }
            else
            {
                Console.WriteLine("incorect minutes");
            }
            int HourInMinutes = (hour * 60);
            int allMinutes = (HourInMinutes + minutes + 15);

            int timeHour = (allMinutes / 60);
            int timeMinutes = (allMinutes % 60);
            
            if (timeHour == 24)
            {
                timeHour = 0;
            }
            Console.WriteLine($"{timeHour}:{timeMinutes:d2}");

            
                   
        }
    }
}
