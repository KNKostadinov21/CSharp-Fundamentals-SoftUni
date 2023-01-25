using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfArray = int.Parse(Console.ReadLine());

            int[] arr = new int[numbersOfArray];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numbersOfArray - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}