using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> removalelements = new List<int>(pokemons.Count);

            if (pokemons.Count == 1)
            {
                removalelements.Add(pokemons[0]);
                pokemons.RemoveAt(0);
            }

            while (pokemons.Count > 0)
            {
                int removal = 0;

                int position = int.Parse(Console.ReadLine());


                if (position < 0)
                {

                    removalelements.Add(pokemons[0]);
                    removal = pokemons[0];
                    pokemons[0] = pokemons[pokemons.Count - 1];

                    for (int i = 0; i < pokemons.Count; i++)
                    {

                        if (pokemons[i] <= removal)
                        {
                            pokemons[i] += removal;
                        }
                        else if (pokemons[i] > removal)
                        {
                            pokemons[i] -= removal;
                        }
                    }
                }
                else if (position > pokemons.Count - 1)
                {
                    removalelements.Add(pokemons[pokemons.Count - 1]);
                    removal = pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = pokemons[0];


                    for (int i = 0; i < pokemons.Count; i++)
                    {

                        if (pokemons[i] <= removal)
                        {
                            pokemons[i] += removal;
                        }
                        else if (pokemons[i] > removal)
                        {
                            pokemons[i] -= removal;
                        }
                    }
                }
                else
                {
                    removal = pokemons[position];



                    pokemons.RemoveAt(position);
                    removalelements.Add(removal);


                    for (int i = 0; i < pokemons.Count; i++)
                    {

                        if (pokemons[i] <= removal)
                        {
                            pokemons[i] += removal;
                        }
                        else if (pokemons[i] > removal)
                        {
                            pokemons[i] -= removal;
                        }
                    }
                }


            }

            Console.WriteLine(removalelements.Sum());
        }
    }
}
