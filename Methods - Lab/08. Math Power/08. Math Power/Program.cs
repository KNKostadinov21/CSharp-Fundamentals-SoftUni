using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static double MathPow(double number, int power)
        {
            double result = Math.Pow(number, power);
            return result;
        }

        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(MathPow(number, power));
        }
    }
}