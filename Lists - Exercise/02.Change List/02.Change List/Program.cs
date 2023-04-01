using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] command = input.Split().ToArray();
            if (command[0] == "Delete") nums.RemoveAll(x => x == int.Parse(command[1]));
            else if (command[0] == "Insert") nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
        }
        Console.WriteLine(string.Join(" ", nums));
    }
}