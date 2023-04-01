using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static (List<int>, bool) Detonation(List<int> list, int bombNumber, int power)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == bombNumber)
                {
                    int start = i - power;
                    int end = i + power;
                    if (start < 0) start = 0;
                    if (end >= list.Count) end = list.Count - 1;
                    list.RemoveRange(start, end - start + 1);
                    return (list, true);
                }
            }
            return (list, false);
        }

        static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] numberAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = numberAndPower[0];
            int power = numberAndPower[1];
            bool hasDetonated = true;
            while (hasDetonated)
            {
                (list, hasDetonated) = Detonation(list, bombNumber, power);
            }
            Console.WriteLine(list.Sum());
        }
    }
}
