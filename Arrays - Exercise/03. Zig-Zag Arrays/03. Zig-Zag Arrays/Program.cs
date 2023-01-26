using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currentElement = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    firstArr[i] = currentElement[0];
                    secondArr[i] = currentElement[1];
                }
                else
                {
                    firstArr[i] = currentElement[1];
                    secondArr[i] = currentElement[0];
                }
            }

            for (int k = 0; k < firstArr.Length; k++)
            {
                Console.Write(firstArr[k] + " ");
            }
            Console.WriteLine();
            for (int l = 0; l < secondArr.Length; l++)
            {
                Console.Write(secondArr[l] + " ");
            }

        }
    }
}