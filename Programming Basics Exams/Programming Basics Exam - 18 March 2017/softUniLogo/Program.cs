using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var simbol = 1;
            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                                new string('.', ((12 * n - 5) / 2) - simbol / 2),
                                new string('#', simbol));
                simbol += 6;
            }
            simbol -= 6;

            for (int i = 0; i < n - 2; i++)
            {
                simbol -= 6;
                Console.WriteLine("|{0}{1}{2}",
                            new string('.', (((12 * n - 5) / 2) - simbol / 2) - 1),
                            new string('#', simbol),
                            new string('.', ((12 * n - 5) / 2) - simbol / 2));
            }
            simbol -= 6;

            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("|{0}{1}{2}",
                           new string('.', (((12 * n - 5) / 2) - simbol / 2) - 1),
                           new string('#', simbol),
                           new string('.', ((12 * n - 5) / 2) - simbol / 2));
            }
            Console.WriteLine("@{0}{1}{2}",
                           new string('.', (((12 * n - 5) / 2) - simbol / 2) - 1),
                           new string('#', simbol),
                           new string('.', ((12 * n - 5) / 2) - simbol / 2));
        }
    }
}