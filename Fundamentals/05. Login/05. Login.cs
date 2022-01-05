using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string logIn = Console.ReadLine();

            string password = "";
            int counter = 0;

            for (int i = username.Length - 1; i > -1; i--)
            {
                password += username[i];
            }

            while (password != logIn)
            {
                counter = counter + 1;

                if (counter > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                logIn = Console.ReadLine();
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
