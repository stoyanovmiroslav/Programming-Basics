using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var minus2 = 0;
                var dif = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}",
                    new string('*', 1+i),
                     new string('-', (2 * n -1)- i * 2));
            }
            for (int i = 0; i < n/3; i++)
            {
                if (n % 2 == 0)
                {
                    dif = 1;
                }
                Console.WriteLine("|{0}\\{1}/{0}|", 
                                      new string('*', ((n-1)/2) +i ),
                                       new string('*', n - minus2 + dif));
                minus2 = minus2 + 2;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}",
                    new string('-', 1 + i),
                     new string('*', (2 * n - 1) - i * 2));
            }
        }
    }
}
