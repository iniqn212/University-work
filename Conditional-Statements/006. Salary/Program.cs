using System;

namespace _006._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 1; i <= tabs; i++)
            {
                string pages = Console.ReadLine();
               
                switch (pages)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                    default:
                        break;
                }
               
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }  
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
             
        }  
    }
}
