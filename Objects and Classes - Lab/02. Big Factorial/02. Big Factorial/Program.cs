using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int number);
            BigInteger factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}