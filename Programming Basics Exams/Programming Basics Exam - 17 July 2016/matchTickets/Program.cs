using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budjed = double.Parse(Console.ReadLine());
            var tipe = Console.ReadLine();
            var numpeople = double.Parse(Console.ReadLine());
            var pecent = 0.00;
            var ticketprice = 0.00;

            if (numpeople >= 1 && numpeople <= 4) pecent = 0.75;
            else if (numpeople >= 5 && numpeople <= 9) pecent = 0.60;
            else if (numpeople >= 10 && numpeople <= 24) pecent = 0.50;
            else if (numpeople >= 25 && numpeople <= 49) pecent = 0.40;
            else if (numpeople > 50) pecent = 0.25;

            if (tipe == "VIP") ticketprice = 499.99;
            else if (tipe == "Normal") ticketprice = 249.99;

            var transport = budjed * pecent;
            var ticket = ticketprice * numpeople;
            var total = budjed - (transport + ticket);

            if (total >= 0)
            {
                Console.WriteLine($"Yes! You have {total:f2} leva left.");
            }
            else
            {
                total = Math.Abs(total);
                Console.WriteLine($"Not enough money! You need {total:f2} leva.");

            }








        }
    }
}
