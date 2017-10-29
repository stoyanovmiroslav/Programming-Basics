using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    class Casle
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(@"/{0}\{1}/{0}\",
              new string('^', n/2),
              new string('_', (n*2) - ((n/2)*2 + 4)));
            for (int i = 1; i <= n-2; i++)
            {
                if (i < n-2)
                {
                    Console.WriteLine("|{0}|",
                    new string(' ', n * 2 - 2));
                }
                else
                {
                    Console.WriteLine("|{0} {1} {0}|",
              new string(' ', n / 2),
              new string('_', (n * 2) - ((n / 2) * 2 + 4)));
                 }
            }

             Console.WriteLine(@"\{0}/{1}\{0}/",
             new string('_', n / 2),
             new string(' ', (n * 2) - ((n / 2) * 2 + 4)));
            


        }
    }
}
