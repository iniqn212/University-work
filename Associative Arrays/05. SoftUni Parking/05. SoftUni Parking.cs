using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<string,string> parkingUsers = new Dictionary<string, string>();

            for (int i = 0; i < number; i++)
            {
                string[] userData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (userData[0] == "register")
                {
                    string userName = userData[1];
                    string userPlate = userData[2];

                    if (parkingUsers.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {userPlate}");
                    }
                    else
                    {
                        parkingUsers.Add(userName, userPlate);
                        Console.WriteLine($"{userName} registered {userPlate} successfully");
                    }
                }
                else if (userData[0] == "unregister")
                {
                    string userName = userData[1];

                    if (parkingUsers.ContainsKey(userName))
                    {
                        parkingUsers.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                }
                
            }

            foreach (var kvp in parkingUsers)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
