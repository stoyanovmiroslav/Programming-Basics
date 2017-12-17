using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var broiTovari = int.Parse(Console.ReadLine());
            var price = 0.00;
            var mikrobus = 0.00;
            var kamion = 0.00;
            var vlak = 0.00;

            for (int i = 0; i < broiTovari; i++)
            {
                var tonajTovar = int.Parse(Console.ReadLine());
                if (tonajTovar <= 3)
                {
                    mikrobus = tonajTovar + mikrobus;
                    price = 200;
                }
                else if (tonajTovar <= 11)
                {
                    kamion = kamion + tonajTovar;
                    price = 175;
                }
                else if (tonajTovar >= 12)
                {
                    vlak = vlak + tonajTovar;
                    price = 120;

                }

            }
            var all = mikrobus + kamion + vlak;
            var sum = (mikrobus * 200 + kamion * 175 + vlak * 120 ) / all;
            Console.WriteLine("{0:f2}", sum);
            Console.WriteLine("{0:f2}%", mikrobus / all*100 );
            Console.WriteLine("{0:f2}%", kamion / all * 100);
            Console.WriteLine("{0:f2}%", vlak / all * 100);



        }
    }
}
