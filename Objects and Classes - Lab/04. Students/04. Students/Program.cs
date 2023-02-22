using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Students
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string info = Console.ReadLine();

            while (info != "end")
            {
                string[] infoArray = info.Split()
                    .ToArray();

                string firstName = infoArray[0];
                string lastName = infoArray[1];
                int age = int.Parse(infoArray[2]);
                string town = infoArray[3];

                Student student = new Student();
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = town;

                students.Add(student);
                info = Console.ReadLine();
            }

            string homeTown = Console.ReadLine();

            foreach (Student currentStudent in students)
            {
                if (currentStudent.HomeTown == homeTown)
                {
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
                }
            }
        }
    }
}