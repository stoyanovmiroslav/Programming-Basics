﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            bool borderX = (x == x1 || x == x2) && (y >= y1 && y <= y2);
            bool borderY = (y == y1 || y == y2) && (x >= x1 && x <= x2);
            bool border = borderX || borderY;
            if (border)
                Console.WriteLine("border");
            else
                Console.WriteLine("Inside / Outside");
        }
    }
}