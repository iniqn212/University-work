using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> studentByCource = new Dictionary<string, List<string>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] parts = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string course = parts[0];
                string student = parts[1];

                if (!studentByCource.ContainsKey(course))
                {
                    studentByCource.Add(course, new List<string>());

                }

                studentByCource[course].Add(student);
            }

            var sortedCource = studentByCource
                .OrderByDescending(i => i.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedCource)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                kvp.Value.Sort();
                
                foreach (var students in kvp.Value)
                {
                    Console.WriteLine($"-- {students}");
                }
            }
            

        }
    }
}
