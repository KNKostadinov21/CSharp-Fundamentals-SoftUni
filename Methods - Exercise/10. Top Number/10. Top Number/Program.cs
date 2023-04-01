using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static bool DigitsSumDivisibleBy8(int num)
        {
            int sumDigits = 0;
            while (num > 0)
            {
                sumDigits += num % 10;
                num /= 10;
            }
            if (sumDigits % 8 == 0) return true;
            else return false;
        }

        static bool HasAtLeastOneOddDigit(int num)
        {
            while (num > 0)
            {
                if (num % 2 == 1) return true;
                num /= 10;
            }
            return false;
        }

        static void Main()
        {
            int endValue = int.Parse(Console.ReadLine());
            for (int i = 1; i <= endValue; i++)
                if (DigitsSumDivisibleBy8(i) && HasAtLeastOneOddDigit(i)) Console.WriteLine(i);
        }
    }
}