using System;

namespace _08._Graduation_pt._2_whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            

            double avaregaGread = 0.0;
            int greadCounter = 1;
            int badGreadCounter = 0;

            while (greadCounter <= 12)
            {
                double gread = double.Parse(Console.ReadLine());
                

                if (gread <= 3 )
                {
                    badGreadCounter += 1;

                    if (badGreadCounter == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {greadCounter} grade");
                        break;
                    }
                }               
                else 
                {
                    avaregaGread += gread;
                    greadCounter += 1;
                }
            }
            if (badGreadCounter != 2)
            {
                greadCounter -= 1;
                avaregaGread = avaregaGread / (greadCounter);
                Console.WriteLine($"{name} graduated. Average grade: {avaregaGread:f2}");
            }  
        }
    }
}
