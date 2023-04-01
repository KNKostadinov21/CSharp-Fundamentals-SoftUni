using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        Dictionary<string, List<double>> studentGradesPair = new Dictionary<string, List<double>>();
        int rowPairs = int.Parse(Console.ReadLine());
        for (int i = 0; i < rowPairs; i++)
        {
            string studentName = Console.ReadLine();
            double studentGrade = double.Parse(Console.ReadLine());
            if (!studentGradesPair.ContainsKey(studentName))
                studentGradesPair.Add(studentName, new List<double>());
            studentGradesPair[studentName].Add(studentGrade);
        }

        foreach (var kvp in studentGradesPair.Where(x => x.Value.Sum() / x.Value.Count >= 4.50))
            Console.WriteLine($"{kvp.Key} -> {kvp.Value.Sum() / kvp.Value.Count:f2}");
    }
}