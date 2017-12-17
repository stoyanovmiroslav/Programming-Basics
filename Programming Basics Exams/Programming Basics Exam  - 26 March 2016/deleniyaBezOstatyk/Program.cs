using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delenieBezOstatak
{
    class delenieBezOstatak
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p2 = 0.00;
            var p3 = 0.00;
            var p4 = 0.00;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number % 2 == 0) p2++;
                if (number % 3 == 0) p3++;
                if (number % 4 == 0) p4++;
            }

            Console.WriteLine("{0:f2}%", p2 / n * 100);
            Console.WriteLine("{0:f2}%", p3 / n * 100);
            Console.WriteLine("{0:f2}%", p4 / n * 100);

        }
    }
}
