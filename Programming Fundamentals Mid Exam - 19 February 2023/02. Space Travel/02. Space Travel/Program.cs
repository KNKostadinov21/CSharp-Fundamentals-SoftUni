using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Space_Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] route = Console.ReadLine().Split("||");
            int fuel = int.Parse(Console.ReadLine());
            int ammo = int.Parse(Console.ReadLine());

            for (int i = 0; i < route.Length; i++)
            {
                string[] command = route[i].Split();
                if (command[0] == "Travel")
                {
                    int distance = int.Parse(command[1]);
                    if (fuel >= distance)
                    {
                        fuel -= distance;
                        Console.WriteLine($"The spaceship travelled {distance} light-years.");
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                }
                else if (command[0] == "Enemy")
                {
                    int enemyArmor = int.Parse(command[1]);
                    if (ammo >= enemyArmor)
                    {
                        ammo -= enemyArmor;
                        Console.WriteLine($"An enemy with {enemyArmor} armour is defeated.");
                    }
                    else if (fuel >= enemyArmor * 2)
                    {
                        fuel -= enemyArmor * 2;
                        Console.WriteLine($"An enemy with {enemyArmor} armour is outmaneuvered.");
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                }
                else if (command[0] == "Repair")
                {
                    int ammoToAdd = int.Parse(command[1]) * 2;
                    int fuelToAdd = int.Parse(command[1]);
                    ammo += ammoToAdd;
                    fuel += fuelToAdd;
                    Console.WriteLine($"Ammunitions added: {ammoToAdd}.");
                    Console.WriteLine($"Fuel added: {fuelToAdd}.");
                }
                else if (command[0] == "Titan")
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                    return;
                }

            }
        }
    }
}