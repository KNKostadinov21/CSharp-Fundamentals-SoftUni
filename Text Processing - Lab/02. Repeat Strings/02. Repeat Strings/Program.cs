using System;
using System.Text;

internal class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        StringBuilder result = new StringBuilder();

        for (int wordCount = 0; wordCount < input.Length; wordCount++)
        {
            string word = input[wordCount];
            for (int i = 0; i < word.Length; i++)
                result.Append(word);
        }
        Console.WriteLine(result.ToString());
    }
}