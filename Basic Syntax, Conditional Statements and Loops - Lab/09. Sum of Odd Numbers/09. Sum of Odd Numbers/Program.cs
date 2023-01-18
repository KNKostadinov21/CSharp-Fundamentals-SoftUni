using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNumber = 1;

            for (int i = 1; i <= numbers; i++)
            {
                sum += currentNumber;
                Console.WriteLine(currentNumber);
                currentNumber += 2;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}