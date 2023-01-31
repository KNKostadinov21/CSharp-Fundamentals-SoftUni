using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int longestSequenceStartIndex = 0;
            int longestSequenceLength = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                int currentSequenceStartIndex = i - 1;
                int currentSequenceLength = 1;

                while (i < arr.Length && arr[i] == arr[i - 1])
                {
                    currentSequenceLength++;
                    i++;
                }

                if (currentSequenceLength > longestSequenceLength)
                {
                    longestSequenceLength = currentSequenceLength;
                    longestSequenceStartIndex = currentSequenceStartIndex;
                }
            }

            for (int i = longestSequenceStartIndex; i < longestSequenceStartIndex + longestSequenceLength; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}