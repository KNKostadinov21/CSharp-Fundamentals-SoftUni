using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(arr);

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}