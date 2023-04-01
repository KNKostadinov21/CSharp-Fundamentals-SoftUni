using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> wordsCounts = new Dictionary<string, int>();
            string[] input = Console.ReadLine().ToLower().Split();
            foreach (string word in input)
            {
                if (!wordsCounts.ContainsKey(word))
                    wordsCounts.Add(word, 0);
                wordsCounts[word]++;
            }
            foreach (KeyValuePair<string, int> word in wordsCounts)
            {
                if (word.Value % 2 == 1)
                    Console.Write(word.Key + " ");
            }
        }
    }
}