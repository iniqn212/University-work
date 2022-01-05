using System;

namespace _05._Travelling_nestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = "";
          
            while (destination != "End")
            {
                destination = Console.ReadLine();

                if (destination == "End")
                {
                    break;
                }
                double priceOfTravel = double.Parse(Console.ReadLine());

                double myMoney = 0;

                while (true)
                {
                    string saveing = Console.ReadLine();
                    
                    if (saveing == "End")
                    {
                        return;
                    }
                    myMoney += double.Parse(saveing);
                  
                    if (myMoney >= priceOfTravel)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        break;
                    }
                }  
            }          
        }
    }
}
