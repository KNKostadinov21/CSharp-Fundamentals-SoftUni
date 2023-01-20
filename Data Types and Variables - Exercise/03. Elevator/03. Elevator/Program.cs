using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());

            if (people % elevatorCapacity == 0)
            {
                Console.WriteLine(people / elevatorCapacity);
            }

            else
            {
                Console.WriteLine((people / elevatorCapacity) + 1);
            }
        }
    }
}