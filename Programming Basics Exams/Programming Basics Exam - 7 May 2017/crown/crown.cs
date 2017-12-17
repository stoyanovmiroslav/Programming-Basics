using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crown
{
    class crown
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var minus2 = 1;
            var prov = 0;
            Console.WriteLine("@{0}@{0}@",
                                    new string(' ',  n - 2));
            Console.WriteLine("**{0}*{0}**",
                                    new string(' ', n - 3));
            for (int i = 1; i <= n /2 ; i++)
            {
                if (i == n / 2 - 1)
                {
                    Console.WriteLine("*{0}*{1}*{0}*",
                                  new string('.', i),
                                 new string('.', minus2));
                    prov++;
                }
                else if (prov != 0)
                {
                    Console.WriteLine("*{0}{1}.{1}{0}*",
                                  new string('.', i),
                                  new string('*', ((2 * n - 1) - (i * 2 + 3)) / 2 )) ;
                }
                else
                {
                    Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",
                                                 new string('.', i),
                                                 new string(' ', ((n * 2 - 1) - (i * 2 + minus2 + 6)) / 2),
                                                new string('.', minus2));
                    minus2 += 2;
                }
                
            }
            Console.WriteLine("{0}", new string('*', n * 2 - 1));
            Console.WriteLine("{0}", new string('*', n * 2 - 1));
        }
    }
}
