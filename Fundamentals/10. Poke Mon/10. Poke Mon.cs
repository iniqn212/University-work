using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int pokeTargets = 0;
            int pokeForce = pokePower;

            while (pokePower >= distance)
            {
                pokePower = pokePower - distance;
                pokeTargets++;

                if (pokePower == (pokeForce / 2))
                {

                    if (exhaustionFactor > 0)
                    {
                        pokePower = pokePower / exhaustionFactor;
                    }
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokeTargets);
        }
    }
}
