using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double pricePerOnePerson = 0;

            if (day == "Friday")
            {
                if (groupType == "Students")
                {
                    pricePerOnePerson = 8.45;
                }
                else if (groupType == "Business")
                {
                    pricePerOnePerson = 10.90;
                }
                else if (groupType == "Regular")
                {
                    pricePerOnePerson = 15.00;
                }
            }
            else if (day == "Saturday")
            {
                if (groupType == "Students")
                {
                    pricePerOnePerson = 9.80;
                }
                else if (groupType == "Business")
                {
                    pricePerOnePerson = 15.60;
                }
                else if (groupType == "Regular")
                {
                    pricePerOnePerson = 20.00;
                }
            }
            else if (day == "Sunday")
            {
                if (groupType == "Students")
                {
                    pricePerOnePerson = 10.46;
                }
                else if (groupType == "Business")
                {
                    pricePerOnePerson = 16.00;
                }
                else if (groupType == "Regular")
                {
                    pricePerOnePerson = 22.50;
                }
            }

            double totalPrice = people * pricePerOnePerson;

            if (people >= 30 && groupType == "Students")
            {
                totalPrice = totalPrice - (0.15 * totalPrice);
            }
            else if (people >= 100 && groupType == "Business")
            {
                totalPrice = totalPrice - (10 * pricePerOnePerson);
            }
            else if (people >= 10 && people <= 20 && groupType == "Regular")
            {
                totalPrice = totalPrice - (0.05 * totalPrice);
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}