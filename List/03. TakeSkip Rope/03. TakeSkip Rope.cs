using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._TakeSkip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
                

            List<char> nonDigits = new List<char>(message.Length);
            List<int> digits = new List<int>(message.Length);

            for (int i = 0; i < message.Length; i++)
            {
                char element = message[i];

                if (char.IsDigit(element))
                {
                    digits.Add(int.Parse(element.ToString()));
                }
                else
                {
                    nonDigits.Add(message[i]);
                }
            }

            List<int> skip = new List<int>(digits.Count);
            List<int> take = new List<int>(digits.Count);

            for (int i = 0; i < digits.Count; i++)
            {
                if (i % 2 == 0)
                {
                    take.Add(digits[i]);
                }
                else
                {
                    skip.Add(digits[i]);
                }
            }
            List<string> hiddenMesage = new List<string>(message.Length);

            string encoding = string.Empty;
            int sum = 0;

            for (int i = 0; i < skip.Count; i++)
            {
                int takeIdx = take[i];
                int skipIdx = skip[i];

                encoding = encoding + new string(nonDigits.Skip(sum).Take(takeIdx).ToArray());
                sum += skipIdx + takeIdx;
            }

            Console.WriteLine(encoding);
        }
    }
}
