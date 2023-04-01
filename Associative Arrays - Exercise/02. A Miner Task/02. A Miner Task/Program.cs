using System;
using System.Collections.Generic;

internal class Program
{
    static void Main()
    {
        Dictionary<string, int> oreQuantityPairs = new Dictionary<string, int>();
        string input;
        while ((input = Console.ReadLine()) != "stop")
        {
            string newOre = input;
            int newQuantity = int.Parse(Console.ReadLine());
            if (!oreQuantityPairs.ContainsKey(newOre))
                oreQuantityPairs.Add(newOre, 0);
            oreQuantityPairs[newOre] += newQuantity;
        }

        foreach (var oreQuantity in oreQuantityPairs)
        {
            Console.WriteLine($"{oreQuantity.Key} -> {oreQuantity.Value}");
        }
    }
}