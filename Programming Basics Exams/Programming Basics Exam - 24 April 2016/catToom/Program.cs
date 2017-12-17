using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class catTom
    {
        static void Main(string[] args)
        {
            var holidays = double.Parse(Console.ReadLine());
            var workdays = 365 - holidays;
            var timeplay = workdays * 63 + holidays * 127;
            var norma = 30000 - timeplay;
            var normaup = timeplay - 30000;
            if (timeplay > 30000)
            {
                Console.WriteLine("Tom will run away");

                var timeHmin = Math.Truncate(normaup / 60);
                var min = normaup % 60;
                Console.WriteLine($"{timeHmin} hours and {min} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");

                var timeH = Math.Truncate(norma / 60);
                var min = norma % 60;
                Console.WriteLine($"{timeH} hours and {min} minutes less for play");


            }


        }
    }
}
