using System;

namespace _06._Cake_whileLoop
{
    class cake
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());

            int areaCake = cakeWidth * cakeLenght;
            int pieceCake = areaCake;
            int takenPiece = 0;

            while (areaCake > takenPiece)
            {
                string input = Console.ReadLine();

                if (input == "STOP")
                {
                    Console.WriteLine($"{pieceCake - takenPiece} pieces are left.");
                    return;
                }
                else
                {
                    int getPiece = int.Parse(input);
                    takenPiece += getPiece;
                }              
            }
            Console.WriteLine($"No more cake left! You need {takenPiece - areaCake} pieces more.");
        }
    }
}
