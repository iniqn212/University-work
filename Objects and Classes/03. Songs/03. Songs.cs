using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int songsValue = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < songsValue; i++)
            {
                string[] songsInfo = Console.ReadLine()
                    .Split("_", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string type = songsInfo[0];
                string name = songsInfo[1];
                string time = songsInfo[2];

                Song song = new Song();
                {
                    song.Typelist = type;
                    song.Name = name;
                    song.Time = time;
                }

                songs.Add(song);
            }

            string request = Console.ReadLine();

            if (request == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else 
            {
                foreach (Song song in songs)
                {
                    if (song.Typelist == request)
                    {
                        Console.WriteLine(song.Name);
                    }
                    
                }
            }        
        }
    }


}
