using System;
using System.Linq;
using System.Collections.Generic;
namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> leftList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> rightList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            int minValue = Math.Min(leftList.Count, rightList.Count);

            for (int i = 0; i < minValue; i++)
            {
                result.Add(leftList[i]);
                result.Add(rightList[i]);
            }

            if (leftList.Count > rightList.Count)
            {
                for (int i = minValue; i < leftList.Count; i++)
                {
                    result.Add(leftList[i]);
                }
            }
            else if (rightList.Count > leftList.Count)
            {
                for (int i = minValue; i < rightList.Count; i++)
                {
                    result.Add(rightList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}