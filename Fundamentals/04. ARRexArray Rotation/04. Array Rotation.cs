﻿using System;
using System.Linq;

namespace _04._ARRexArray_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotation = int.Parse(Console.ReadLine());
            
            

            for (int j = 0; j < rotation; j++)
            {
                int temp = array[0];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[array.Length - 1] = temp;
            }
            
            Console.WriteLine(String.Join(" ", array));
        }
    }
}