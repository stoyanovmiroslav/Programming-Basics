using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var kmPerMonth = int.Parse(Console.ReadLine());
            var amoutForKm = 0.00;
            if (kmPerMonth <= 20000 && kmPerMonth > 10000)
            {
                amoutForKm = 1.45;
            }
            
            else if (kmPerMonth <= 10000 && kmPerMonth > 5000)
            {
                if (season == "Summer") amoutForKm = 1.10;
                else if (season == "Spring" || season == "Autumn") amoutForKm = 0.95;
                else if (season == "Winter") amoutForKm = 1.25;
            }
            else if (kmPerMonth <= 5000)
            {
                if (season == "Summer") amoutForKm = 0.90;
                else if (season == "Spring" || season == "Autumn") amoutForKm = 0.75;
                else if (season == "Winter") amoutForKm = 1.05;

            }
            var sum = amoutForKm * kmPerMonth * 4;
            var danaci = sum * 0.10;
            var result = sum - danaci;
            Console.WriteLine("{0:f2}", result);
        }
    }
}
