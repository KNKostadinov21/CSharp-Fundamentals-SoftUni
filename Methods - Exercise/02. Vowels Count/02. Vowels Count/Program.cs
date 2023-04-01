using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void PrintNumberOfVowels(string str)
        {
            int vowelCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'a':
                    case 'e':
                    case 'o':
                    case 'i':
                    case 'u': vowelCount++; break;
                }
            }
            Console.WriteLine(vowelCount);
        }

        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            PrintNumberOfVowels(input);
        }
    }
}
