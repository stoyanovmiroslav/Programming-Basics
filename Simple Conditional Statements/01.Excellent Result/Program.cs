﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            var grate = double.Parse(Console.ReadLine());
            if (grate >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
