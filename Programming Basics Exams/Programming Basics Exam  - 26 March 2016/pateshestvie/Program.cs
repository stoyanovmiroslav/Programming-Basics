using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var budjed = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            string place = "";
            var budjedsummer = 0.00;
            var budjetwinter = 0.00;

            if (budjed <= 100)
            {
                place = "Bulgaria";
                budjedsummer = 0.30;
                budjetwinter = 0.70;
            }
            else if (budjed <= 1000)
            {
                place = "Balkans";
                budjedsummer = 0.40;
                budjetwinter = 0.80;
            }
            else if (budjed > 1000)
            {
                place = "Europe";

                budjedsummer = 0.90;
                budjetwinter = 0.90;
            }
            if (place == "Europe")
            {
                var result = budjedsummer * budjed;
                Console.WriteLine("Somewhere in {0}", place);
                Console.WriteLine("Hotel - {0:f2}", result);
            }
            else if (season == "summer")
            {
                var result = budjedsummer * budjed;
                Console.WriteLine("Somewhere in {0}", place);
                Console.WriteLine("Camp - {0:f2}", result);
            }
            else
            {
                var result = budjetwinter * budjed;
                Console.WriteLine("Somewhere in {0}", place);
                Console.WriteLine("Hotel - {0:f2}", result);
            }

        }
    }
}
