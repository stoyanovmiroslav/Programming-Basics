using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var j = 0;
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}{1}{0}", 
                    new string('.', n + i),
                    new string('#', (5 * n) - (n+i)*2 ));
                j = n + i + 1;
            }
            for (int i = 0; i < (n/2)+1; i++)
            {
                Console.WriteLine("{0}#{1}#{0}",
                                  new string('.', j + i),
                                  new string('.', ((5 * n) - (j + i) * 2) - 2 ));
            }
            Console.WriteLine("{0}{1}{0}",
                new string('.', n*2),
                new string('#', n));

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                new string('.', n * 2 - 2),
                new string('#', n + 4));
            }

            Console.WriteLine("{0}D^A^N^C^E^{0}",
                           new string('.', ((5 * n) - 10)/ 2));

            for (int i = 0; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                new string('.', n * 2 - 2),
                new string('#', n + 4));
            }
        }
    }
}
