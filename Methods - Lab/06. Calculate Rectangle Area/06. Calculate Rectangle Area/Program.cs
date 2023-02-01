using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static double RectangleCalculation(double height, double width)
        {
            return height * width;
        }

        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine(RectangleCalculation(height, width));
        }
    }
}