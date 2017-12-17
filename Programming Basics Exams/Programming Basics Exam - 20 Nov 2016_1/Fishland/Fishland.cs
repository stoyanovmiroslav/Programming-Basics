using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Fishland
    {
        static void Main(string[] args)
        {
            var skumriyaPriceKg = double.Parse(Console.ReadLine());
            var cacaPriceKg = double.Parse(Console.ReadLine());
            var kilogramPalamut = double.Parse(Console.ReadLine());
            var kilogramSafrit = double.Parse(Console.ReadLine());
            var kilogramMidi = int.Parse(Console.ReadLine());

            var palamutPrice = skumriyaPriceKg + (skumriyaPriceKg * 0.60);
            var safritPrice = cacaPriceKg + (cacaPriceKg * 0.80);

            var palamut = palamutPrice * kilogramPalamut;
            var safrit = safritPrice * kilogramSafrit;
            var midi = kilogramMidi * 7.50;
            var smetka = palamut + safrit + midi;
            Console.WriteLine("{0:f2}", smetka);


        }
    }
}
