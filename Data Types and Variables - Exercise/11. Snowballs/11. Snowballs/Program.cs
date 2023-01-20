using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberSnowballs = int.Parse(Console.ReadLine());
            BigInteger highestSnowballValue = 0;
            int highestSnowballSnow = 0;
            int highestSnowballTime = 0;
            int highestSnowballQuality = 0;

            for (int i = 1; i <= numberSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                if (snowballTime > 0)
                {
                    BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);


                    if (highestSnowballValue < snowballValue)
                    {
                        highestSnowballValue = snowballValue;
                        highestSnowballSnow = snowballSnow;
                        highestSnowballTime = snowballTime;
                        highestSnowballQuality = snowballQuality;
                    }
                }
            }

            Console.WriteLine($"{highestSnowballSnow} : {highestSnowballTime} = {highestSnowballValue} ({highestSnowballQuality})");
        }
    }
}