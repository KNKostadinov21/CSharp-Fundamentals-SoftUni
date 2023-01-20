using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersLiters = int.Parse(Console.ReadLine());
            int totalQuantity = 255;

            for (int i = 1; i <= numbersLiters; i++)
            {
                int currentLiters = int.Parse(Console.ReadLine());

                if (totalQuantity - currentLiters >= 0)
                {
                    totalQuantity -= currentLiters;
                }

                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(255 - totalQuantity);
        }
    }
}