using System;

namespace _01.Old_Books_whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string wantedBook = Console.ReadLine();
            string books = Console.ReadLine();
            int checkedBooks = 1;

            while (wantedBook != books)
            {
                books = Console.ReadLine();
                checkedBooks += 1;
                
                if (books == "No More Books")
                {
                    checkedBooks -= 1;
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {checkedBooks} books.");
                    return;
                }
            }
            checkedBooks -= 1;
            Console.WriteLine($"You checked {checkedBooks} books and found it.");
        }
    }
}
