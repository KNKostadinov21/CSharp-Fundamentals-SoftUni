using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int[] arr = new int[numbers];

            int totalSum = 0;
            for (int i = 0; i < numbers; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                totalSum += arr[i];
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(totalSum);
        }
    }
}