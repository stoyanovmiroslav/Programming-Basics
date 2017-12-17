using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lozeRakiya
{
    class Program
    {
        static void Main(string[] args)
        {
            var ploshtLoze = double.Parse(Console.ReadLine());
            var kmOfkvm = double.Parse(Console.ReadLine());
            var waste = double.Parse(Console.ReadLine());


            var grozde = (ploshtLoze * kmOfkvm) - waste;
            var Rakiya45 = grozde * 0.45;
            var grozdrProdan = grozde * 0.55;
            var rakiya = Rakiya45 / 7.5;
            var rakiyawin = rakiya * 9.8;
            var grodewin = grozdrProdan * 1.50;

            Console.WriteLine($"{rakiyawin:f2}");
            Console.WriteLine($"{grodewin:f2}");



        }
    }
}
