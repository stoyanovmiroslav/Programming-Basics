using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            var NumbersOfKm = int.Parse(Console.ReadLine());
            var dayOrNight = Console.ReadLine();
            var tarrif = 0.00;

            if (NumbersOfKm >= 100) tarrif = 0.06 * NumbersOfKm;
            else if (NumbersOfKm >= 20) tarrif = 0.09 * NumbersOfKm;
            else if (dayOrNight == "day") tarrif = 0.79 * NumbersOfKm + 0.70;
            else if (dayOrNight == "night") tarrif = 0.90 * NumbersOfKm + 0.70;

            Console.WriteLine(tarrif);

        }
    }
}
