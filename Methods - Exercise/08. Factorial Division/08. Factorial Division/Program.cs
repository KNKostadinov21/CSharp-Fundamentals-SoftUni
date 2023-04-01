using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static decimal GetFactorial(decimal n)
        {
            decimal result = 1m;
            for (int i = 1; i <= n; i++) result *= i;
            return result;
        }

        static decimal FactorialDivision(decimal a, decimal b)
        {
            return GetFactorial(a) / GetFactorial(b);
        }

        static void Main()
        {
            decimal first = decimal.Parse(Console.ReadLine());
            decimal second = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{FactorialDivision(first, second):f2}");
        }
    }
}
