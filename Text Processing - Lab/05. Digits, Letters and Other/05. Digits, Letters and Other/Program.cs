using System;
using System.Text;

internal class Program
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        StringBuilder digits = new StringBuilder();
        StringBuilder letters = new StringBuilder();
        StringBuilder other = new StringBuilder();

        foreach (char c in inputString)
        {
            if (char.IsDigit(c)) digits.Append(c);
            else if (char.IsLetter(c)) letters.Append(c);
            else other.Append(c);
        }
        Console.WriteLine(digits);
        Console.WriteLine(letters);
        Console.WriteLine(other);
    }
}