using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentData = new Dictionary<string, List<double>>();

            for (int i = 0; i < number; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!studentData.ContainsKey(studentName))
                {
                    studentData.Add(studentName, new List<double>());
                }

                studentData[studentName].Add(studentGrade);
            }

            Dictionary<string, double> sortedStudentData = studentData
                .Select(s => new KeyValuePair<string , double>(s.Key , s.Value.Average()))
                .Where(s => s.Value >= 4.5)
                .OrderByDescending(s => s.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedStudentData)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }
    }
}
/* стандартен ввариант неоптиизиран 
                 Dictionary<string, List<double>> sortedStudentData = studentData
                .Where(s => s.Value.Average() >= 4.5)
                .OrderByDescending(s => s.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);
*/