using System;
using System.Text;

internal class Program
{
    static void Main()
    {
        string[] bannedWords = Console.ReadLine().Split(", ");
        string bigText = Console.ReadLine();

        foreach (string word in bannedWords)
        {
            string replacement = new String('*', word.Length);

            while (bigText.Contains(word))
                bigText = bigText.Replace(word, replacement);
        }

        Console.WriteLine(bigText);
    }
}