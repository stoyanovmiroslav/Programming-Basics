using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var ploshtHouse = double.Parse(Console.ReadLine());
            var numberOfWindows = int.Parse(Console.ReadLine());
            var kvmStirioporOnePackeg = double.Parse(Console.ReadLine());
            var priceOnePackegStiriopor = double.Parse(Console.ReadLine());

            var plosht = ploshtHouse - (numberOfWindows * 2.4);
            var moreTenPercent = plosht * 0.10;
            moreTenPercent = plosht + moreTenPercent;
            var packedge = Math.Ceiling(moreTenPercent / kvmStirioporOnePackeg);
            var cena = packedge * priceOnePackegStiriopor;

           
            if ( budget >= cena)
            {
                var left = budget - cena;
                Console.WriteLine($"Spent: {cena:f2}");
                Console.WriteLine($"Left: {left:f2}");
            }
            else
            {
                var need = cena - budget;
                Console.WriteLine($"Need more: {need:f2}");
            }





        }
    }
}
