﻿using System;

namespace _05.Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i]; 
                Console.WriteLine(text[i]);
            }  
        }
    }
}
