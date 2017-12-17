using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_1
{
    class Distance
    {
        static void Main(string[] args)
        {
            var km = int.Parse(Console.ReadLine());
            var time1 = int.Parse(Console.ReadLine());
            var time2 = int.Parse(Console.ReadLine());
            var time3 = int.Parse(Console.ReadLine());

            var time1hour = (double)time1 / 60;
            var time2hour = (double)time2 / 60;
            var time3hour = (double)time3 / 60;

            var firstSpeed = km * time1hour;
            var pove10 = km + (km * 0.1);
           var secondSpeed = pove10 * time2hour;
            var nam5 = pove10 - (pove10 * 0.05);
            var tirthSpeed = nam5 * time3hour;
            var totalKm = firstSpeed + secondSpeed + tirthSpeed;

            Console.WriteLine("{0:f2}", totalKm);
        }
    }
}
