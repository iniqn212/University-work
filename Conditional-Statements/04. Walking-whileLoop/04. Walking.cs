using System;

namespace _04._Walking_whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetSteps = 10000;
            int currentSteps = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    int goHomeSteps = int.Parse(Console.ReadLine());
                    currentSteps += goHomeSteps;
                    if (currentSteps >= targetSteps)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{currentSteps - targetSteps} steps over the goal!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"{targetSteps - currentSteps} more steps to reach goal.");
                        return;
                    }  
                }

                int steps = int.Parse(input);
                currentSteps += steps;

                if (currentSteps >= targetSteps)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{currentSteps - targetSteps} steps over the goal!");
                    return;
                }
            }
        }
    }
}
