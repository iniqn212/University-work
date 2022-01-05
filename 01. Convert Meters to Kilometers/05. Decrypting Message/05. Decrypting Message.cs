using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                char symbols = char.Parse(Console.ReadLine());

                int script = symbols + key;
                char decript = (char)script;

                Console.Write(decript);
            }
        }
    }
}
