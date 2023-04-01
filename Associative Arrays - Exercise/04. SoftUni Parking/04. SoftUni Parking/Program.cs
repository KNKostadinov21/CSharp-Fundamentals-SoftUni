using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main()
    {
        Dictionary<string, string> registry = new Dictionary<string, string>();
        int numberCommands = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberCommands; i++)
        {
            string[] input = Console.ReadLine().Split();
            if (input[0] == "register") Register(registry, input[1], input[2]);
            else if (input[0] == "unregister") Unregister(registry, input[1]);
        }
        PrintResult(registry);
    }

    private static void Unregister(Dictionary<string, string> registry, string user)
    {
        if (!registry.ContainsKey(user))
            Console.WriteLine($"ERROR: user {user} not found");
        else
        {
            registry.Remove(user);
            Console.WriteLine($"{user} unregistered successfully");
        }
    }

    private static void Register(Dictionary<string, string> registry, string user, string plateNumber)
    {
        if (registry.ContainsKey(user))
            Console.WriteLine($"ERROR: already registered with plate number {registry[user]}");
        else
        {
            registry.Add(user, plateNumber);
            Console.WriteLine($"{user} registered {plateNumber} successfully");
        }
    }

    private static void PrintResult(Dictionary<string, string> registry)
    {
        foreach (var user in registry)
            Console.WriteLine($"{user.Key} => {user.Value}");
    }
}