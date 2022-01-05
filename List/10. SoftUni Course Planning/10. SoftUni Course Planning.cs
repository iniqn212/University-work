using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> scheduele = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {

                string input = Console.ReadLine();
                                 
                if (input == "course start")
                {
                    break;
                }
                string[] command = input
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string lesson = string.Empty;

                string operation = command[0];

                if (operation.ToLower() == "add")
                {
                     lesson = command[1];

                    if (!scheduele.Contains(lesson))
                    {
                        scheduele.Add(lesson);
                    }
                }
                else if (operation.ToLower() == "insert")
                {
                    lesson = command[1];
                    int idx = int.Parse(command[2]);

                    if (!scheduele.Contains(lesson))
                    {
                        scheduele.Insert(idx, lesson);
                    }
                }
                else if (operation.ToLower() == "remove")
                {
                    lesson = command[1];

                    if (scheduele.Contains(lesson))
                    {
                        scheduele.Remove(lesson);
                    }
                    if (scheduele.Contains(($"{lesson}-Exercise")))
                    {
                        scheduele.Remove(($"{lesson}-Exercise"));
                    }
                }
                else if (operation.ToLower() == "swap")
                {
                    string lessonOne = command[1];
                    string lessonTwo = command[2];

                    if (scheduele.Contains(lessonOne) && scheduele.Contains(lessonTwo))
                    {
                        
                        int lessonOneIdx = -1;
                        int lessonTwoIdx = -1;

                        for (int i = 0; i < scheduele.Count; i++)
                        {
                            if (scheduele[i] == lessonOne)
                            {
                                lessonOneIdx = i;
                            }
                            if (scheduele[i] == lessonTwo)
                            {
                                lessonTwoIdx = i;
                            }
                        }

                        string temp = lessonOne;
                        scheduele[lessonOneIdx] = lessonTwo;
                        scheduele[lessonTwoIdx] = temp;
                        bool IsContains = true;

                        if (scheduele.Contains(($"{lessonOne}-Exercise")))
                        {                           
                            scheduele.Insert(lessonTwoIdx + 1 , ($"{lessonOne}-Exercise"));
                        }
                        else
                        {
                            IsContains = false;
                        }
                        if (scheduele.Contains(($"{lessonTwo}-Exercise")))
                        {
                            if (!IsContains)
                            {
                                string tempKeeper = scheduele[lessonTwoIdx + 1];
                                scheduele.RemoveAt(lessonTwoIdx + 1);
                                scheduele.Insert(lessonOneIdx + 1, tempKeeper);
                            }
                            else
                            {
                                scheduele.Insert(lessonOneIdx + 1, ($"{lessonTwo}-Exercise"));
                            }
                            
                           
                        }
                    }
                }
                else if (operation.ToLower() == "exercise")
                {
                    lesson = command[1];
                    int lessonIdx = -1;

                    if (scheduele.Contains(lesson) && !scheduele.Contains($"{lesson}-Exercise"))
                    {
                        for (int i = 0; i < scheduele.Count; i++)
                        {
                            if (scheduele[i] == lesson)
                            {
                                lessonIdx = i;
                            }
                        }

                        scheduele.Insert(lessonIdx + 1, ($"{lesson}-Exercise"));
                    }
                    else if (!scheduele.Contains(lesson))
                    {
                        scheduele.Add(lesson);
                        scheduele.Add(($"{lesson}-Exercise"));
                    }
                }
            }

            for (int i = 0; i < scheduele.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{scheduele[i]}");
            }
        }
    }
}
