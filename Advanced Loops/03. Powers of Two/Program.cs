﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(num);
                num = num * 2;
            }
            Console.WriteLine(num);
        }
    }
}
