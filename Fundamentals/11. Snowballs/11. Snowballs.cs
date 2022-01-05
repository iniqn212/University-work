using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowBalls = int.Parse(Console.ReadLine());

            int snowBallSnow = 0;
            int snowBallTime = 0;
            int snowBallQuality = 0;

            BigInteger highestSnowBall = 0;

            for (int i = 1; i <= snowBalls; i++)
            {
                 int snow = int.Parse(Console.ReadLine());
                 int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());

                BigInteger snowBallCalc = BigInteger.Pow(snow / time, quality);

                if (snowBallCalc >= highestSnowBall)
                {
                    snowBallSnow = snow;
                    snowBallTime = time;
                    snowBallQuality = quality;
                    highestSnowBall = snowBallCalc;
                }
            }
            Console.WriteLine($"{snowBallSnow} : { snowBallTime} = { highestSnowBall} ({ snowBallQuality})");
        }
    }
}
