using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Phone_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine()
                .Split(", ")
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                string[] commandInfo = command.Split(" - ");

                if (commandInfo[0] == "Add")
                {
                    if (!phones.Contains(commandInfo[1]))
                    {
                        phones.Add(commandInfo[1]);
                    }
                }
                else if (commandInfo[0] == "Remove")
                {
                    if (phones.Contains(commandInfo[1]))
                    {
                        phones.Remove(commandInfo[1]);
                    }
                }
                else if (commandInfo[0] == "Bonus phone")
                {
                    string[] bonusParts = commandInfo[1].Split(":");
                    string oldPhone = bonusParts[0];
                    string newPhone = bonusParts[1];
                    int index = phones.IndexOf(oldPhone);
                    if (index != -1)
                    {
                        phones.Insert(index + 1, newPhone);
                    }
                }
                else if (commandInfo[0] == "Last")
                {
                    if (phones.Contains(commandInfo[1]))
                    {
                        phones.Remove(commandInfo[1]);
                        phones.Add(commandInfo[1]);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid command.");
                }
            }

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
