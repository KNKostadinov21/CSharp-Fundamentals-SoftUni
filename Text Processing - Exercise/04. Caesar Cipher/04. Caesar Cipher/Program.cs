using System;
using System.Text;

internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder result = new StringBuilder();

        foreach (char c in input)
            result.Append((char)(c + 3));
        Console.WriteLine(result);
    }
}