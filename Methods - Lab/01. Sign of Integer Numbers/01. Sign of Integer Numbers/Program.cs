using System;

namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void signOfNumber(int number)
        {
            if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is positive.");
            }
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            signOfNumber(number);
        }
    }
}
