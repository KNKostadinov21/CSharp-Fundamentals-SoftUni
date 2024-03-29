﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();
            foreach (var num in nums)
            {
                if (!counts.ContainsKey(num))
                    counts.Add(num, 0);
                counts[num]++;
            }
            foreach (var count in counts)
            {
                Console.WriteLine($"{count.Key} -> {count.Value}");
            }
        }
    }
}
