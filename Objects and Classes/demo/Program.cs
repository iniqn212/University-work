using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog()
            { 
                Name = "Sharo",
                Breed = "Pitbull",
                Age = 4
            };

            Dog dog2 = new Dog()
            {
                Name = "Baucho",
                Breed = "Koferman",
                Age = 3
            };

           
            dog.SayHi();
            dog2.SayHi();
        }
    }
}
