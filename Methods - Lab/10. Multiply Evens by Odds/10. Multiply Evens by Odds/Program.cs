using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static int DigitMultiplication(int number)
        {
            int evenDigitsSum = 0;
            int oddDigitsSum = 0;

            int numberCopy = Math.Abs(number);
            while (numberCopy > 0)
            {
                int digit = numberCopy % 10;

                if (digit % 2 == 0)
                {
                    evenDigitsSum += digit;
                }
                else
                {
                    oddDigitsSum += digit;
                }

                numberCopy /= 10;
            }

            return evenDigitsSum * oddDigitsSum;
        }
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int number);

            Console.WriteLine(DigitMultiplication(number));
        }
    }
}