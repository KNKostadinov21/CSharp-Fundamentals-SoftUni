using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int pokePowerCopy = pokePower;
            int distanceBetweenThePokeTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int targetsReachedCounter = 0;

            while (pokePower >= distanceBetweenThePokeTargets)
            {
                pokePower -= distanceBetweenThePokeTargets;
                targetsReachedCounter++;

                if (pokePowerCopy * 0.5 == pokePower && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targetsReachedCounter);
        }
    }
}