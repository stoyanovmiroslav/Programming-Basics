﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butterfly
{
    class butterfly
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(@"{0}\ /{0}",
                                     new string('*', n - 2));
                else
                    Console.WriteLine(@"{0}\ /{0}",
                                    new string('-', n - 2));

            }

            Console.WriteLine("{0}@", new string(' ', n - 1));

            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(@"{0}/ \{0}",
                                     new string('*', n - 2));
                else
                    Console.WriteLine(@"{0}/ \{0}",
                                    new string('-', n - 2));

            }
        }
    }
}
