using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }

        public void SayHi()
        {
            Console.WriteLine("Bau Bay Bay Hi");
            Console.WriteLine($"My name is: {Name}, Breed is {Breed}");
            Console.WriteLine("Bye");
        }
    }
}
