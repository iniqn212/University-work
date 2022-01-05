using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Studentss> students = new List<Studentss>();

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


                if (IsStudentExisting(name, lastName, students))
                {
                    Studentss student = GetStudent(students, name, lastName, age);

                }
                else
                {
                    Studentss student = new Studentss();
                    {
                        student.FirstName = name;
                        student.LastName = lastName;
                        student.Age = age;
                        student.HomeTown = city;
                    }
                    students.Add(student);
                }

            }

            string neededTown = Console.ReadLine();

            foreach (Studentss student in students)
            {
                if (student.HomeTown == neededTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }

        }

        private static Studentss GetStudent(List<Studentss> students, string name, string lastName, int age)
        {
            Studentss existingStudent = null;

            foreach (Studentss student in students)
            {
                if (student.FirstName == name && student.LastName == lastName)
                {
                    existingStudent = student;
                    existingStudent.Age = age;
                }
            }
            return existingStudent;
        }

        private static bool IsStudentExisting(string name, string lastName, List<Studentss> students)
        {
            foreach (Studentss student in students)
            {
                if (student.FirstName == name && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Studentss
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
