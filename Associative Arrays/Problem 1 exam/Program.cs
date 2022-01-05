using System;
using System.Linq;

namespace ConsoleApp2
{
    public class Program
    {
        public static void Main()
        {
            string email = Console.ReadLine();

            while (true)
            {
                var input = Console.ReadLine().Split();

                string command = input[0];

                if (command == "Valid")
                {
                    break;
                }

                if (command == "Upper")
                {
                    int index = int.Parse(input[1]);

                    if (char.IsLetter(email[index]))
                    {
                        string elem = email[index].ToString().ToUpper();

                        email = email.Replace(email[index].ToString(), elem);
                    }

                    Console.WriteLine(email);
                }
                else if (command == "Lower")
                {
                    int index = int.Parse(input[1]);

                    if (char.IsLetter(email[index]))
                    {
                        string elem = email[index].ToString().ToLower();

                        email = email.Replace(email[index].ToString(), elem);
                    }

                    Console.WriteLine(email);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(input[1]);

                    email = email.Insert(index, input[2]);

                    Console.WriteLine(email);
                }
                else if (command == "Change")
                {
                    char toReplace = input[1][0];
                    int value = int.Parse(input[2]);

                    char result = (char)((int)toReplace + value);

                    if (email.Contains(toReplace))
                    {
                        email = email.Replace(toReplace, result);
                    }

                    Console.WriteLine(email);
                }
                else if (command == "Validation")
                {
                    if (email.Length < 6)
                    {
                        Console.WriteLine("Email must be at least 6 characters long!");
                    }
                    if (!email.All(c => Char.IsLetterOrDigit(c) || c.Equals('@')))
                    {
                        Console.WriteLine("Email must consist only of letters, digits and @!");
                    }
                    if (email.Count(c => char.IsUpper(c)) < 1)
                    {
                        Console.WriteLine("Email must consist at least one uppercase letter!");
                    }
                    if (email.Count(c => char.IsLower(c)) < 1)
                    {
                        Console.WriteLine("Email must consist at least one lowercase letter!");
                    }
                    if (email.Count(c => char.IsDigit(c)) < 1)
                    {
                        Console.WriteLine("Email must consist at least one digit!");
                    }
                }
            }
        }
    }
}