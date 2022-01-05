using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            double lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsetTrash = (Math.Floor(lostGamesCount / 2) * headsetPrice);
            double mouseTrash = (Math.Floor(lostGamesCount / 3) * mousePrice);
            double keyboardTrash = Math.Floor(lostGamesCount / 6);
            double displayTrash = 0;

            if (keyboardTrash == 2)
            {
                displayTrash = 1 * displayPrice;
            }
            else if (keyboardTrash > 2)
            {
                displayTrash = (Math.Floor(keyboardTrash / 2) * displayPrice);
            }
            double keyboardCosts = keyboardTrash * keyboardPrice;
            Console.WriteLine($"Rage expenses: {headsetTrash + mouseTrash + keyboardCosts + displayTrash:f2} lv.");
        }
    }
}
