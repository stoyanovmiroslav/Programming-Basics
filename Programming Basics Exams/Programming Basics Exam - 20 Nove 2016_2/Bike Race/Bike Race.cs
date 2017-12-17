using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var bikesJuniors = int.Parse(Console.ReadLine());
            var bikesSeniors = int.Parse(Console.ReadLine());
            var trace = Console.ReadLine();
            var juniors = 0.00;
            var seniors = 0.00;


            if (trace == "trail")
            {
                juniors = 5.50;
                seniors = 7;
            }
            else if (trace == "cross-country")
            {
                if (bikesSeniors + bikesJuniors >= 50)
                {
                    juniors = 8 - (8 * 0.25);
                    seniors = 9.50 - (9.50 * 0.25);
                }
                else
                {
                    juniors = 8;
                    seniors = 9.50;
                }

            }
            else if (trace == "downhill")
            {
                juniors = 12.25;
                seniors = 13.75;
            }
            else if (trace == "road")
            {
                juniors = 20;
                seniors = 21.50;
            }
          
                var taxjuniors = bikesJuniors * juniors;
            var taxseniors = bikesSeniors * seniors;
            var razhodi = taxjuniors + taxseniors;
            var razhodi2 = razhodi - (razhodi * 0.05);

            Console.WriteLine("{0:f2}", razhodi2);
        }
    }
}
