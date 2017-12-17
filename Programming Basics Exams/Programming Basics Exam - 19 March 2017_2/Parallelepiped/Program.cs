using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var prom = 0;
            Console.WriteLine("+{0}+{1}",
                             new string('~', n - 2),
                             new string('.', n * 2 + 1));
            for (int i = 0; i <= n * 2; i++)
            {
                Console.WriteLine(@"|{0}\{1}\{2}",
                                  new string('.', i),
                              new string('~', n - 2),
                         new string('.', n * 2 - i));
                prom = i;
            }
            for (int i = 0; i <= n*2; i++)
            {
                Console.WriteLine(@"{0}\{1}|{2}|",
                                  new string('.', i),
                                  new string('.', prom - i),
                              new string('~', n - 2));
            }
            Console.WriteLine("{0}+{1}+",
                             new string('.', n * 2 + 1),
                             new string('~', n - 2));
        }

    }
}
