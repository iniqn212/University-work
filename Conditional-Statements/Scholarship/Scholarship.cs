using System;

namespace Scholarship
{
    class Scholarship
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minimumSalary = double.Parse(Console.ReadLine());

            double socialScholMoney = minimumSalary * 0.35; ;
            double gradeScholMoney = grade * 25;

            if (income < minimumSalary && grade >= 5.5)
            {
                if (socialScholMoney == gradeScholMoney)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(gradeScholMoney)} BGN");
                }
                else if (socialScholMoney > gradeScholMoney)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholMoney)} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(gradeScholMoney)} BGN");
                }

            }
           
            else if ( income < minimumSalary && grade > 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholMoney)} BGN");
            }
           else  if (grade >= 5.5) 
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(gradeScholMoney)} BGN");
            }
            else
            {

                Console.WriteLine("You cannot get a scholarship!"); 
            }

        }
    }
}
