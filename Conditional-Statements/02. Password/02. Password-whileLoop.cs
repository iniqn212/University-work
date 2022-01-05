using System;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentUserName = Console.ReadLine();
            string currentPassword = Console.ReadLine();

            
            string password = Console.ReadLine();

            while ( password != currentPassword )
            {
                password = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {currentUserName}!");
            
        }
    }
}
