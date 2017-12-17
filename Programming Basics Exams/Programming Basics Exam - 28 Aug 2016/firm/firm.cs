using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firm
{
    class firm
    {
        static void Main(string[] args)
        {
            var needHours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var workersOverPaid = int.Parse(Console.ReadLine());

            var afterTrainings = days - (days * 0.1);
            var doprabota = workersOverPaid * days * 2;
            afterTrainings = afterTrainings * 8;
            var allhours = Math.Floor(afterTrainings + doprabota);

            if (allhours >= needHours)
            {
                allhours = allhours - needHours;
                Console.WriteLine($"Yes!{allhours} hours left.");
            }
            else 
            {
                allhours = needHours - allhours;
                Console.WriteLine($"Not enough time!{allhours} hours needed.");
            }

        }
    }
}
