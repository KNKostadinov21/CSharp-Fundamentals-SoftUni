using System;
using System.Linq;
using System.Text;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void PrintAllCharsInBetween(char first, char second)
        {
            for (int i = first + 1; i < second; i++)
            {
                Console.Write((char)i + " ");
            }
        }

        static void Main()
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());
            if (symbol1 < symbol2) PrintAllCharsInBetween(symbol1, symbol2);
            else PrintAllCharsInBetween(symbol2, symbol1);
        }
    }
}
