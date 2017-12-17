using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            var numberOfnumbers = int.Parse(Console.ReadLine());
            var p1 = 0.00;
            var p2 = 0.00;
            var p3 = 0.00;
            var p4 = 0.00;
            var p5 = 0.00;
            for (int i = 0; i < numberOfnumbers; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number < 200) p1++;
                else if (number >= 200 && number <= 399) p2++;
                else if (number >= 400 && number <= 599) p3++;
                else if (number >= 600 && number <= 799) p4++;
                else if (number >= 800) p5++;
            }
            p1 = p1 / numberOfnumbers * 100;
            p2 = p2 / numberOfnumbers * 100;
            p3 = p3 / numberOfnumbers * 100;
            p4 = p4 / numberOfnumbers * 100;
            p5 = p5 / numberOfnumbers * 100;

            Console.WriteLine("{0:f2}%",p1);
            Console.WriteLine("{0:f2}%",p2);
            Console.WriteLine("{0:f2}%",p3);
            Console.WriteLine("{0:f2}%",p4);
            Console.WriteLine("{0:f2}%",p5);


        }
    }
}
