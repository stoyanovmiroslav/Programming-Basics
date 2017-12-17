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
            var forNo = 0;

            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a < b && b < c && a + b + c == n)
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {n}");
                            forNo++;
                        }
                        if (a > b && b > c && a * b * c == n)
                        {
                            Console.WriteLine($"{a} * {b} * {c} = {n}");
                            forNo++;
                        }

                    }
                }
            }
            if (forNo == 0)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
