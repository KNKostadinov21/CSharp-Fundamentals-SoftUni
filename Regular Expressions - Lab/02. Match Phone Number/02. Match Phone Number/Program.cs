using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

internal class Program
{
    static void Main()
    {
        string regex = @"\+359([ -])2\1\d{3}\1\d{4}\b";
        string phones = Console.ReadLine();

        MatchCollection phoneMatches = Regex.Matches(phones, regex);
        List<string> matchedPhones = phoneMatches.Cast<Match>().Select(m => m.Value).ToList();

        Console.Write(String.Join(", ", matchedPhones));

    }
}