using System;
using System.Linq;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string left = "left";
            const string right = "right";

            int fieldSize = int.Parse(Console.ReadLine());
            int[] positions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] ladybugsOnField = new int[fieldSize];

            foreach (var position in positions)
            {
                if (position >= 0 && position < fieldSize)
                {
                    ladybugsOnField[position] = 1;
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string[] instructions = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int position = int.Parse(instructions[0]);
                string direction = instructions[1];
                int flightLength = int.Parse(instructions[2]);

                if (position < 0 || position >= fieldSize || ladybugsOnField[position] == 0)
                {
                    continue;
                }

                if (direction == left)
                {
                    flightLength *= -1;
                }

                bool hasLanded = false;
                ladybugsOnField[position] = 0;

                do
                {
                    position += flightLength;

                    if (position < 0 || position >= fieldSize)
                    {
                        break;
                    }

                    if (ladybugsOnField[position] == 0)
                    {
                        hasLanded = true;
                        ladybugsOnField[position] = 1;
                    }
                }
                while (!hasLanded);
            }

            Console.WriteLine(string.Join(" ", ladybugsOnField));
        }
    }
}