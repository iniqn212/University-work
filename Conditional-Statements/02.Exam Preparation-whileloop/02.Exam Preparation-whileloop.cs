using System;

namespace _02.Exam_Preparation_whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int badResult = int.Parse(Console.ReadLine());

            string nameOfExam = "";


            double averageGread = 0.0;
            int examCounter = 0;
            int badCounter = 0;

            while (badCounter != badResult)
            {
                string nameOfExams = Console.ReadLine();
                
                if (nameOfExams == "Enough")
                {
                    break;
                }
                nameOfExam = nameOfExams;
                double examResult = double.Parse(Console.ReadLine());
                examCounter++;
                averageGread += examResult;
       
                 if (examResult <= 4)
                {
                    badCounter++;
                }
               
                if (badCounter == badResult)
                {
                    Console.WriteLine($"You need a break, {badResult} poor grades.");
                    return;
                }
            }
            Console.WriteLine($"Average score: {(averageGread / examCounter):f2}");
            Console.WriteLine($"Number of problems: {examCounter}");
            Console.WriteLine($"Last problem: {nameOfExam}");
        }
    }
}
