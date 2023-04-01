using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] commands = input.Split(new string[] { " : " }, StringSplitOptions.None);
            string course = commands[0];
            string student = commands[1];
            if (!courses.ContainsKey(course))
                courses.Add(course, new List<string>());
            courses[course].Add(student);
        }

        foreach (KeyValuePair<string, List<string>> course in courses)
        {
            Console.WriteLine($"{course.Key}: {course.Value.Count}");
            course.Value.ForEach(x => Console.WriteLine($"-- {x}"));
        }
    }
}