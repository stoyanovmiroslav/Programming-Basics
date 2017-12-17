using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacityStadium = int.Parse(Console.ReadLine());
            var numberOfFens = int.Parse(Console.ReadLine());
            var a = 0.00;
            var b = 0.00;
            var v = 0.00;
            var g = 0.00;


            for (int i = 0; i < numberOfFens; i++)
            {
                var sector = Console.ReadLine();
                if (sector == "A") a++;
                else if (sector == "B") b++;
                else if (sector == "V") v++;
                else if (sector == "G") g++;
            }
            Console.WriteLine("{0:f2}%", a / numberOfFens * 100);
            Console.WriteLine("{0:f2}%", b / numberOfFens * 100);
            Console.WriteLine("{0:f2}%", v / numberOfFens * 100);
            Console.WriteLine("{0:f2}%", g / numberOfFens * 100);
            Console.WriteLine("{0:f2}%", (double)numberOfFens / capacityStadium  * 100);
            
        }
    }
}
