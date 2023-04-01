using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> companyData = new Dictionary<string, List<string>>();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] commands = input.Split(new string[] { " -> " }, StringSplitOptions.None);
            string company = commands[0];
            string employee = commands[1];
            if (!companyData.ContainsKey(company))
                companyData.Add(company, new List<string>());
            if (!companyData[company].Contains(employee))
                companyData[company].Add(employee);
        }

        foreach (KeyValuePair<string, List<string>> company in companyData)
        {
            Console.WriteLine(company.Key);
            foreach (string employee in company.Value)
            {
                Console.WriteLine($"-- {employee}");
            }
        }
    }
}