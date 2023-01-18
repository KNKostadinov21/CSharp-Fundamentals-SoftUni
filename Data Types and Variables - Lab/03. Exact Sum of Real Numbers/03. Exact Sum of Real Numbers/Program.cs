using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            decimal totalSum = 0;

            for (int i = 1; i <= numbers; i++)
            {
                decimal currentNumber = decimal.Parse(Console.ReadLine());
                totalSum += currentNumber;
            }

            Console.WriteLine(totalSum);
        }
    }
}