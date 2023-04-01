using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._House_Party
{
    internal class Program
    {
        static void Main()
        {
            List<string> list = new List<string>();
            int numberOfLines = int.Parse(Console.ReadLine());
            for (int line = 0; line < numberOfLines; line++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string name = input[0];
                if (input[2] == "not") 
                {
                    if (list.Contains(name)) list.Remove(name);
                    else Console.WriteLine($"{name} is not in the list!");
                }
                else 
                {
                    if (list.Contains(name)) Console.WriteLine($"{name} is already in the list!");
                    else list.Add(name);
                }
            }
            Console.WriteLine(string.Join("\n", list));
        }
    }
}
