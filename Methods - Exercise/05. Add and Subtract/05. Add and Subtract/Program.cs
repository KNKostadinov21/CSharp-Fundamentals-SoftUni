using System;
using System.Linq;
using System.Text;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static int SumNumbers(int x, int y)
        {
            return x + y;
        }

        static int SubtractNumbers(int x, int y)
        {
            return x - y;
        }

        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(SubtractNumbers(SumNumbers(a, b), c));
        }
    }
}