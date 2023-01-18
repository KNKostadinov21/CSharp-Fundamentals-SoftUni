using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            double numberLightsabers = Math.Ceiling(1.10 * students);
            double numberRobes = students;
            double numberBelts = students - Math.Floor((students / 6.0));

            double neededSum = (numberLightsabers * priceLightsabers) + (numberRobes * priceRobes) + (numberBelts * priceBelts);

            if (budget >= neededSum)
            {
                Console.WriteLine($"The money is enough - it would cost {neededSum:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(neededSum - budget):F2}lv more.");
            }
        }
    }
}