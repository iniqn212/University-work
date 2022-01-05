using System;
using System.Collections.Generic;
using System.Linq;

namespace _01m_Messaging
{
    class messages
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string message = Console.ReadLine();

            

            for (int i = 0; i < numbers.Count; i++)
            {

                int currentNum = numbers[i];

                int index = GetIndex(currentNum);

                char letter = GetLetter(message, index);
                Console.Write(letter);

                int indexCOunter = IndexCounter(index, message);
                string currentMessage = message.Remove(indexCOunter , 1);
                message = currentMessage;
            }


        }

        private static int IndexCounter(int index, string message)
        {
            int countIdx = 0;

            for (int i = 0; i < index; i++)
            {
                countIdx++;

                if (countIdx == message.Length)
                {
                    countIdx = 0;
                }
            }
            return countIdx;
        }

        private static char GetLetter(string message, int index)
        {
            int countIdx = 0;

            for (int i = 0; i < index; i++)
            {
                countIdx++;

                if (countIdx == message.Length)
                {
                    countIdx = 0;
                }
            }

            char letter = message[countIdx];
            return letter;
        }

        private static int GetIndex(int currentNum)
        {
            int idx = 0;

            while (currentNum > 0)
            {
               
                int lastNum = currentNum % 10;
                idx += lastNum;
                currentNum /= 10;
            }

            return idx;
        }
    }
}