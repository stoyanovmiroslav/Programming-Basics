using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombinations
{
    class MaxCombinations
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var plus2 = 0;

            Console.WriteLine("{0}{1}{0}",
                          new string('.', n),
                          new string('*', n * 3),
                          new string('.', n));
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                             new string('.', n - i),
                             new string('.', n * 3 + plus2));
                plus2 += 2;
            }
            Console.WriteLine("{0}", new string('*', n * 5));
            plus2 = 0;
            for (int i = 1; i < n * 2 + 1; i++)
            {

                Console.WriteLine("{0}*{1}*{0}",
                             new string('.', i),
                             new string('.', n * 5 - 4 - plus2));
                plus2 += 2;
            }
            plus2 += 2;

            Console.WriteLine("{0}{1}{0}",
                               new string('.', n * 2 + 1),
                               new string('*', n * 5 - plus2));



        }
    }
}