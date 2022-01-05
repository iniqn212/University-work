using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> companyData = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] info = input
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string companyName = info[0];
                string employeeId = info[1];

                if (!companyData.ContainsKey(companyName))
                {
                    companyData.Add(companyName, new List<string>());

                    if (!companyData[companyName].Contains(employeeId))
                    {
                        companyData[companyName].Add(employeeId);
                    }
                }

                if (!companyData[companyName].Contains(employeeId))
                {
                    companyData[companyName].Add(employeeId);
                }


            }

            foreach (var company in companyData)
            {
                Console.WriteLine(company.Key);

                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }

        }
    }
}
