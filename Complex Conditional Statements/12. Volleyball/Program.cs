using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine().ToLower();
            var numberHoliday = int.Parse(Console.ReadLine());
            var weekendsToBornTown = int.Parse(Console.ReadLine());

            var playHoliday = numberHoliday * 2.0 / 3;
            var weekendsInSofia = 48 - weekendsToBornTown;
            var dayOffWeekendsSofia = weekendsInSofia * 3.0 / 4;
            var play = dayOffWeekendsSofia + playHoliday + weekendsToBornTown;
            if (year == "leap")
            {
                var result = play * 0.15;
                Console.WriteLine((int)(play + result));

            }
            else if (year == "normal")
            {
                Console.WriteLine((int)play);
            }
        }
    }
}
