using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bradva
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var j = 0;
            var two = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                     new string('-', n * 3),
                     new string('-', i),
                     new string('-', (5 * n) - ((n * 3) + i + 2)));
                j = i;
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                     new string('*', n * 3),
                     new string('-', j),
                     new string('-', (5 * n) - ((n * 3) + j + 2)));
            }
            for (int i = 0; i < n / 2; i++)
            {
                if (i == (n / 2 - 1))
                {
                    Console.WriteLine("{0}*{1}*{2}",
                                       new string('-', (n * 3) - i),
                                       new string('*', j + two),
                                       new string('-', (5 * n) - ((n * 3) + j + 2 + i)));
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{2}",
                    new string('-', (n * 3) - i),
                    new string('-', j + two),
                    new string('-', (5 * n) - ((n * 3) + j + 2 + i)));
                }
                two += 2;
            }

        }
    }
}
