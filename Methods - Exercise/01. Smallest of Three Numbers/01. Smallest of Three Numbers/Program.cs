using System;
using System.Linq;

class Program
{
    static void PrintSmallestNumber(int a, int b, int c)
    {
        int smallest = Math.Min(a, b);
        smallest = Math.Min(smallest, c);
        Console.WriteLine(smallest);
    }

    static void Main()
    {       
        (int one, int two, int three) nums = (0, 0, 0);
        nums.one = int.Parse(Console.ReadLine());
        nums.two = int.Parse(Console.ReadLine());
        nums.three = int.Parse(Console.ReadLine());
        PrintSmallestNumber(nums.one, nums.two, nums.three);
    }
}