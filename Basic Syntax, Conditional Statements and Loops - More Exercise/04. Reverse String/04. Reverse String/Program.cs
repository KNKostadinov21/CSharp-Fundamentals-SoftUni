using System;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();
            string reversedString = null;

            for(int i = stringInput.Length - 1; i >= 0; i--)
            {
                reversedString += stringInput[i];
            }

            Console.WriteLine(reversedString);
        }
    }
}