using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void PrintMiddleChars(string str)
        {
            if (str.Length % 2 == 0)
                Console.WriteLine($"{str[str.Length / 2 - 1]}{str[str.Length / 2]}");
            else Console.WriteLine(str[str.Length / 2]);
        }

        static void Main()
        {
            string input = Console.ReadLine();
            PrintMiddleChars(input);
        }
    }
}
