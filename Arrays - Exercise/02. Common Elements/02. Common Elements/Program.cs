using System;
using System.Linq;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                .Split()
                .ToArray();
            string[] secondArr = Console.ReadLine()
                .Split()
                .ToArray();

            foreach (var item in firstArr)
            {
                for (int i = 0; i < secondArr.Length; i++)
                {
                    if (item == secondArr[i])
                    {
                        Console.Write(item + " ");
                        break;
                    }
                }
            }
        }
    }
}