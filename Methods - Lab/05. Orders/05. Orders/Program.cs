using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Order(string product, int quantity)
        {
            double pricePerOne = 0;

            switch (product)
            {
                case "coffee":
                    pricePerOne = 1.50; break;
                case "water":
                    pricePerOne = 1.00; break;
                case "coke":
                    pricePerOne = 1.40; break;
                case "snacks":
                    pricePerOne = 2.00; break;
            }

            Console.WriteLine($"{(quantity * pricePerOne):F2}");
        }

        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Order(product, quantity);
        }
    }
}