using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SborIliProizvedenie
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var minus2 = 0;
            var i = 0;
            Console.WriteLine("{0}", new string('#', n * 4 + 1));
            for (i = 1; i <= n; i++)
            {
                if (i == n / 2 + 1)
                {
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}",
                                      new string('.', i),
                                      new string('#', (n * 4 + 1) / 2 - 1 - minus2),
                                      new string(' ', (1 + minus2 - 3) / 2));
                }
                else
                    Console.WriteLine("{0}{1}{2}{1}{0}",
                        new string('.', i),
                        new string('#', (n * 4 + 1) / 2 - 1 - minus2),
                        new string(' ', 1 + minus2));

                minus2 += 2;
            }
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("{0}{1}{0}",
                   new string('.', i + j),
                   new string('#', ((n * 4 + 1) - (i + j) * 2)));

            }

        }
    }
}
