using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            bool hasChanges = false;
            while (command != "end")
            {
                string[] commandInfo = command.Split();

                if (commandInfo[0] == "Add")
                {
                    int number = int.Parse(commandInfo[1]);
                    numbers.Add(number);
                    hasChanges = true;
                }
                else if (commandInfo[0] == "Remove")
                {
                    int number = int.Parse(commandInfo[1]);
                    numbers.Remove(number);
                    hasChanges = true;
                }
                else if (commandInfo[0] == "RemoveAt")
                {
                    int index = int.Parse(commandInfo[1]);
                    numbers.RemoveAt(index);
                    hasChanges = true;
                }
                else if (commandInfo[0] == "Insert")
                {
                    int number = int.Parse(commandInfo[1]);
                    int index = int.Parse(commandInfo[2]);
                    numbers.Insert(index, number);
                    hasChanges = true;
                }
                else if (commandInfo[0] == "Contains")
                {
                    int number = int.Parse(commandInfo[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (commandInfo[0] == "PrintEven")
                {
                    foreach (var item in numbers)
                    {
                        if (item % 2 == 0)
                        {
                            Console.Write(item + " ");
                        }
                    }

                    Console.WriteLine();
                }
                else if (commandInfo[0] == "PrintOdd")
                {
                    foreach (var item in numbers)
                    {
                        if (item % 2 == 1)
                        {
                            Console.Write(item + " ");
                        }
                    }

                    Console.WriteLine();
                }
                else if (commandInfo[0] == "GetSum")
                {
                    int sum = 0;

                    foreach (var item in numbers)
                    {
                        sum += item;
                    }

                    Console.WriteLine(sum);
                }
                else if (commandInfo[0] == "Filter")
                {
                    string condition = commandInfo[1];
                    int number = int.Parse(commandInfo[2]);

                    if (condition == "<")
                    {
                        foreach (var item in numbers)
                        {
                            if (item < number)
                            {
                                Console.Write(item + " ");
                            }
                        }

                        Console.WriteLine();
                    }
                    else if (condition == ">")
                    {
                        foreach (var item in numbers)
                        {
                            if (item > number)
                            {
                                Console.Write(item + " ");
                            }
                        }

                        Console.WriteLine();
                    }
                    else if (condition == ">=")
                    {
                        foreach (var item in numbers)
                        {
                            if (item >= number)
                            {
                                Console.Write(item + " ");
                            }
                        }

                        Console.WriteLine();
                    }
                    else if (condition == "<=")
                    {
                        foreach (var item in numbers)
                        {
                            if (item <= number)
                            {
                                Console.Write(item + " ");
                            }
                        }

                        Console.WriteLine();
                    }
                }

                command = Console.ReadLine();
            }

            if (hasChanges)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}