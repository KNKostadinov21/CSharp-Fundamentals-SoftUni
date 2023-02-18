using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());

            int[] currentLongestSequence = new int[dnaLength];
            int currentSequenceLength = 0;
            int currentStartingIndex = 0;
            int currentSum = 0;
            int dnaNumber = 0;

            int counter = 0;
            while (true)
            {
                counter++;
                string input = Console.ReadLine();

                if (input == "Clone them!")
                {
                    break;
                }

                int[] arr = input
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int length = 0;

                foreach (var item in arr)
                {
                    if (item == 1)
                    {
                        length++;
                    }
                    else if (item == 0 && length > 0)
                    {
                        break;
                    }
                }

                int startingIndex = Array.IndexOf(arr, 1);
                int sum = arr.Sum();

                if (length > currentSequenceLength
                    || length == currentSequenceLength
                    && currentStartingIndex > startingIndex
                    || length == currentStartingIndex
                    && sum > currentSum)
                {
                    currentLongestSequence = arr;
                    currentSequenceLength = length;
                    currentStartingIndex = startingIndex;
                    currentSum = sum;
                    dnaNumber = counter;
                }
            }

            Console.WriteLine($"Best DNA sample {dnaNumber} with sum: {currentSum}.");
            Console.WriteLine(string.Join(' ', currentLongestSequence));
        }
    }
}