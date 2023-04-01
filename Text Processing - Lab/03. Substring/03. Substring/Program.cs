using System;
using System.Text;

internal class Program
{
    static void Main()
    {
        string subString = Console.ReadLine();
        string mainString = Console.ReadLine();

        while (mainString.Contains(subString))
        {
            int index = mainString.IndexOf(subString);
            mainString = mainString.Remove(index, subString.Length);
        }

        Console.WriteLine(mainString);
    }
}