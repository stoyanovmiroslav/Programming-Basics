﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string firstLastRow = new string('*', 2 * n);
            firstLastRow = firstLastRow + new string(' ', n);
            firstLastRow = firstLastRow + new string('*', 2 * n);
            Console.WriteLine(firstLastRow);
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("*");
                Console.Write(new string('/', 2 * n - 2));
                Console.Write("*");

                if (i == ((n - 1) / 2 - 1))
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }
                Console.Write("*");
                Console.Write(new string('/', 2 * n - 2));
                Console.WriteLine("*");
            }
            Console.WriteLine(firstLastRow);
        }
    }
}

