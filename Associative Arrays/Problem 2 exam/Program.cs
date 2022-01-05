using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string patern = @"(?<laborName>[A-Z][a-z]{2,} [A-Z][a-z]{2,})#+(?<jobPos>[A-Z][A-Za-z]+&?([A-Za-z]+)?&?([A-Za-z]+))?[0-9]{2}(?<company>[A-Z][A-Za-z0-9]+) (?<kind>Ltd.|JSC)";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Regex regex = new Regex(patern);
                Match match = regex.Match(input);

                if (match.Success)
                {
                    Console.WriteLine($"{match.Groups["laborName"].Value} is {match.Groups["jobPos"].Value.Replace("&", " ")} at {match.Groups["company"].Value} {match.Groups["kind"].Value}");
                }
            }
        }
    }
}