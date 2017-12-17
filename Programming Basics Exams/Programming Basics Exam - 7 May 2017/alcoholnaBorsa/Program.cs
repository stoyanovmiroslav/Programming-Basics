using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alcoholnaBorsa
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceWisky = double.Parse(Console.ReadLine());
            var beer = double.Parse(Console.ReadLine());
            var wine = double.Parse(Console.ReadLine());
            var rakiya = double.Parse(Console.ReadLine());
            var wisky = double.Parse(Console.ReadLine());

            var priceRakiya = priceWisky / 2;
            var priceWine = priceRakiya - (priceRakiya * 0.4);
            var priceBeer = priceRakiya - (priceRakiya * 0.8);
            var sumbbeer = beer * priceBeer;
            var sumwine = priceWine * wine;
            var sumrakiya = priceRakiya * rakiya;
            var sumwisky = priceWisky * wisky;
            var sum = sumbbeer + sumrakiya + sumwine + sumwisky;

            Console.WriteLine("{0:f2}", sum);


        }
    }
}
