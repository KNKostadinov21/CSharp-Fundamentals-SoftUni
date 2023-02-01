using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static string StringRepeats(string str, int repeats)
        {
            string newString = string.Empty;
            for (int i = 1; i <= repeats; i++)
            {
                newString += str;
            }

            return newString;
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());

            Console.WriteLine(StringRepeats(str, repeats));
        }
    }
}