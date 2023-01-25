using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] secondArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool areSame = true;

            foreach (var currentNum in firstArr)
            {
                sum += currentNum;
            }

            for (int i = 0; i < secondArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    areSame = false;
                    break;
                }
            }

            if (areSame)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}