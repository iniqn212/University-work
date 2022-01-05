using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> memberBySide = new Dictionary<string, List<string>>();

            Dictionary<string, string> allMembers = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();
                 

                if (input == "Lumpawaroo")
                {
                    break;
                }

                if (input.Contains(" | "))
                {
                    string[] parts = input
                        .Split(" | ");

                    string forceSide = parts[0];
                    string forceUser = parts[1];

                    if (allMembers.ContainsKey(forceUser))
                    {
                        continue;
                    }
                    else
                    {
                        if (!memberBySide.ContainsKey(forceSide))
                        {
                            memberBySide.Add(forceSide, new List<string>());
                        }

                        memberBySide[forceSide].Add(forceUser);
                        allMembers.Add(forceUser, forceSide);
                    }
                   
                }
                   // If you receive a forceUser->forceSide, you should check if there is such a forceUser already and if so,
                   // change his/ her side.If there is no such forceUser, add him/ her to the corresponding forceSide, 
                   // treating the command as a new registered forceUser.
                   // Then you should print on the console: "{forceUser} joins the {forceSide} side!"
                else
                {
                    string[] parts = input
                        .Split(" -> ");

                    string forceUser = parts[0];
                    string forceSide = parts[1];

                    if (allMembers.ContainsKey(forceUser))
                    {
                        if (!memberBySide.ContainsKey(forceSide))
                        {
                            memberBySide.Add(forceSide, new List<string>());
                        }
                        string currentSide = allMembers[forceUser];

                        memberBySide[forceSide].Add(forceUser);
                        memberBySide[currentSide].Remove(forceUser);
                        allMembers.Remove(forceUser);
                        allMembers.Add(forceUser, forceSide);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else if (!allMembers.ContainsKey(forceUser))
                    {
                        if (!memberBySide.ContainsKey(forceSide))
                        {
                            memberBySide.Add(forceSide, new List<string>());
                        }

                        memberBySide[forceSide].Add(forceUser);
                        allMembers.Add(forceUser, forceSide);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                }
            }
         
        }
    }
}
