﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liceNaTriangle_
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = int.Parse(Console.ReadLine());
            var y1 = int.Parse(Console.ReadLine());
            var x2 = int.Parse(Console.ReadLine());
            var y2 = int.Parse(Console.ReadLine());
            var x3 = int.Parse(Console.ReadLine());
            var y3 = int.Parse(Console.ReadLine());

            int a = Math.Abs(x2 - x3);
            int h = Math.Abs(y2 - y1);
            var lice = (double)a * h / 2;
            Console.WriteLine(lice);


        }
    }
}
