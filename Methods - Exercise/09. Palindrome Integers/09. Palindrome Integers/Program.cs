using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static bool DetermineIfPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
                if (str[i] != str[str.Length - 1 - i]) return false;

            return true;
        }

        static void Main()
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
                Console.WriteLine(DetermineIfPalindrome(input));
        }
    }
}