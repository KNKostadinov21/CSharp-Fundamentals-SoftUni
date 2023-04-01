using System;
using System.Linq;

namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToArray();
            foreach (string word in words)
                Console.WriteLine(word);
        }
    }
}
