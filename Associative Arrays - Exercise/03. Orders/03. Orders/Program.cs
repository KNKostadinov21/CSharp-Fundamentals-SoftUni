using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    public class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double GetTotalPrice() => Price * Quantity;
    }

    static void Main()
    {
        List<Product> allProducts = new List<Product>();
        string input;
        while ((input = Console.ReadLine()) != "buy")
        {
            string[] inputTokens = input.Split();

            string newName = inputTokens[0];
            double newPrice = double.Parse(inputTokens[1]);
            int newQuantity = int.Parse(inputTokens[2]);
            Product newEntry = new Product(newName, newPrice, newQuantity);

            if (!(allProducts.Select(x => x.Name).Contains(newEntry.Name)))
                allProducts.Add(newEntry);
            else
            {
                foreach (Product v in allProducts.Where(v => v.Name == newEntry.Name))
                {
                    v.Price = newPrice;
                    v.Quantity += newQuantity;
                }
            }
        }

        foreach (Product v in allProducts)
            Console.WriteLine($"{v.Name} -> {v.GetTotalPrice():f2}");
    }
}