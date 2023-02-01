using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static double Calculation(double firstNum, string operations, double secondNum)
        {
            double result = 0;

            switch (operations)
            {
                case "+":
                    result = firstNum + secondNum; break;
                case "-":
                    result = firstNum - secondNum; break;
                case "*":
                    result = firstNum * secondNum; break;
                case "/":
                    result = firstNum / secondNum; break;
            }

            return result;
        }

        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculation(firstNum, operation, secondNum));
        }
    }
}