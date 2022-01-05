using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> resources = new Dictionary<string, double>();

            int lineCounter = -1;
            string resourceName = string.Empty;
            double resourceValue = 0;

            while (true)
            {

                string input = Console.ReadLine();
                lineCounter++;

                if (input == "stop")
                {
                    break;
                }

                if (lineCounter % 2 == 0)
                {
                    resourceName = input;
                }
                else if (lineCounter % 2 != 0)
                {
                    resourceValue = double.Parse(input);
                }

                if (lineCounter % 2 != 0 && lineCounter >= 1)
                {


                    if (resources.ContainsKey(resourceName))
                    {
                        resources[resourceName] += resourceValue;
                    }
                    else
                    {
                        resources.Add(resourceName, resourceValue);
                    }


                }
            }

            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
