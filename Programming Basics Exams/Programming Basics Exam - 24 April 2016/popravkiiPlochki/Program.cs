using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remontnaplochki
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = double.Parse(Console.ReadLine());
            var W = double.Parse(Console.ReadLine());
            var L = double.Parse(Console.ReadLine());
            var M = double.Parse(Console.ReadLine());
            var O = double.Parse(Console.ReadLine());

            var ploshtadkastrana = N * N;
            var plochka = W * L;
            var peika = M * O;
            var ploshtpokrivane = ploshtadkastrana - peika;
            var broiplochki = ploshtpokrivane / plochka;
            var vreme = broiplochki * 0.2;
            Console.WriteLine("{0:f2}", broiplochki);
            Console.WriteLine("{0:f2}", vreme);






        }
    }
}
