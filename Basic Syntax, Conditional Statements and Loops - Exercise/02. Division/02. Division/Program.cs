using System;

namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int dividor = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (i == 2 || i == 3 || i == 6 || i == 7 || i == 10)
                {
                    if (number % i == 0)
                    {
                        dividor = i;
                    }
                }
            }

            if (dividor != 0)
            {
                Console.WriteLine($"The number is divisible by {dividor}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}