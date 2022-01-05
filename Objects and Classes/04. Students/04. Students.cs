using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "end")
                {
                    break;
                }

                string[] data = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = data[0];
                string lastName = data[1];
                int age = int.Parse(data[2]);
                string city = data[3];

                Students student = new Students();
                {
                    student.firsName = name;
                    student.lastName = lastName;
                    student.age = age;
                    student.homeTown = city;
                }

                students.Add(student);
            }

            string neededTown = Console.ReadLine();

            foreach (Students student in students)
            {
                if (student.homeTown == neededTown)
                {
                    Console.WriteLine($"{student.firsName} {student.lastName} is {student.age} years old.");
                }
            }
        }
    }
}
