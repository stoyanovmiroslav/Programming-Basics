using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    class hospital
    {
        static void Main(string[] args)
        {
            var period = int.Parse(Console.ReadLine());
            
            var lekari = 7;
            var treated = 0;
            var untreated = 0;


            for (int i = 1; i <= period; i++)
            {
                var patients = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && untreated > treated)
                {
                    lekari++;
                }
                if (patients > lekari)
                {
                    untreated = (patients - lekari) + untreated;
                    treated = lekari + treated;
                }
                else
                {
                    treated = patients + treated;
                }
            
            }

            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", untreated);

        }
    }
}
