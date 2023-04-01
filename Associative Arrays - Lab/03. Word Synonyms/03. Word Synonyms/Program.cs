using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
        int countWords = int.Parse(Console.ReadLine());
        for (int i = 0; i < countWords; i++)
        {
            string newWord = Console.ReadLine();
            string newSynonym = Console.ReadLine();
            if (!words.ContainsKey(newWord))
                words.Add(newWord, new List<string>());
            words[newWord].Add(newSynonym);
        }
        foreach (KeyValuePair<string, List<string>> word in words)
        {
            Console.WriteLine($"{word.Key} - {String.Join(", ", word.Value)}");
        }
    }
}