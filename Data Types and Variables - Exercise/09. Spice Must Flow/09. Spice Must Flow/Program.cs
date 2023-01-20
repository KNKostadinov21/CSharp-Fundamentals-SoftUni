using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int daysOperated = 0;
            int sum = 0;
            int spicePerDay = 0;

            while (yield >= 100)
            {
                daysOperated += 1;
                spicePerDay = yield - 26;
                sum += spicePerDay;
                yield -= 10;
            }

            if (daysOperated > 0)
            {
                sum -= 26;
            }

            Console.WriteLine(daysOperated);
            Console.WriteLine(sum);
        }
    }
}