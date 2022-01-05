using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOfCommand = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>(NumberOfCommand);


            for (int i = 0; i < NumberOfCommand; i++)
            {
                string[] guestNameAndStatus = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .ToArray();

                string name = guestNameAndStatus[0];
                string status = guestNameAndStatus[1]+guestNameAndStatus[2];

                if (status == "isgoing!")
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                    

                }
                else if (status == "isnot")
                {
                    if (!guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else
                    {
                        guests.Remove(name);
                    }
                }
               
            }

            Console.WriteLine(string.Join("\n", guests));
        }
    }
}
