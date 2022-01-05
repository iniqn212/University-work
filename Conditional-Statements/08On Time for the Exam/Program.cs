using System;

namespace _08On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int hourArive = int.Parse(Console.ReadLine());
            int minutesArive = int.Parse(Console.ReadLine());

            double convertExamTime = (examHour * 60) + examMinutes;
            double convertAriveTime = (hourArive * 60) + minutesArive;

            double difference = convertExamTime - convertAriveTime;
            double difHour =(difference / 60);
            double difMinutes = (difference % 60);

            if (difference < 0 )
            {
                Console.WriteLine("Late"); 


                if (difference < 0 && difference >= -59)
                {
                    Console.WriteLine($"{Math.Abs(difMinutes):00} minutes after the start");
                }
                else
                {
                    
                    Console.WriteLine($"{Math.Abs(difHour):0}:{Math.Abs(difMinutes):00} hours after the start");
                }
            }
            else if (difference >= 0 && difference <= 30)
            {
                if (difference == 0)
                {
                    Console.WriteLine(" On time");
                }
                else
                {
                    Console.WriteLine(" On time");
                    Console.WriteLine($"{Math.Abs(difMinutes)} minutes before the start");
                }
            }
            else if (difference > 30)
            {
                Console.WriteLine("Early");

                if (difference > 30 && difference < 59)
                {
                    Console.WriteLine($"{Math.Abs(difMinutes):00} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(difHour):0}:{Math.Abs(difMinutes):00} hours before the start");
                }
            }
        }
    }
}
                    
            
                
                    
                

