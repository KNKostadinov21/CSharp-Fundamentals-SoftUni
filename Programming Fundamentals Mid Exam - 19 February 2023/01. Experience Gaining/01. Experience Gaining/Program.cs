using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;

namespace _01._Experience_Gaining
{
    internal class Program
    {

        static void Main(string[] args)
        {
            double neededExperience = double.Parse(Console.ReadLine());
            int battleCount = int.Parse(Console.ReadLine());
            double experiencePerBattle;
            double totalExperience = 0;

            for (int i = 1; i <= battleCount; i++)
            {
                experiencePerBattle = double.Parse(Console.ReadLine());

                if (i % 15 == 0)
                {
                    experiencePerBattle *= 1.05;
                }

                if (i % 5 == 0)
                {
                    experiencePerBattle *= 0.9;
                }

                if (i % 3 == 0)
                {
                    experiencePerBattle *= 1.15;
                }

                totalExperience += experiencePerBattle;

                if (totalExperience >= neededExperience)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    return;
                }
            }

            double moreNeeded = neededExperience - totalExperience;
            Console.WriteLine($"Player was not able to collect the needed experience, {moreNeeded:f2} more needed.");
        }
    }
}