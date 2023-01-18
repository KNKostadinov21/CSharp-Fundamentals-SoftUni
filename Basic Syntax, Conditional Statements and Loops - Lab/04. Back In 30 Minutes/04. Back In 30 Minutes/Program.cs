﻿using System;

namespace _04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if (minutes >= 60)
            {
                hour += 1;
                minutes -= 60;
            }

            if (hour >= 24)
            {
                hour -= 24;
            }

            Console.WriteLine($"{hour}:{minutes:D2}");
        }
    }
}