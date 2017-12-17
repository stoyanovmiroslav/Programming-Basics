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
            var bit = double.Parse(Console.ReadLine());
            var una = double.Parse(Console.ReadLine());
            var comision = double.Parse(Console.ReadLine());


            var unadolar = una * 0.15;
            var dolarvela = unadolar * 1.76;
            var bitleva = bit * 1168;
            var sumaleva = dolarvela + bitleva;
            var eur = sumaleva / 1.95;
            //var endeur = eur * (comision * 0.01 + 1) ; // procent??
            //var eeu2 = endeur - eur;
            //var eurtotal = eur - eeu2;
            var eura = eur / 100 * comision;
            var total = eur - eura;

            Console.WriteLine("{0:f2}", total);




        }
    }
}
