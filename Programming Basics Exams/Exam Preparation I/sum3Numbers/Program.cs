using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            var min = Math.Min(a, b);
            min = Math.Min(min , c);
            var max = Math.Max(a, b);
            max = Math.Max(max, c);
            var mid = 0;

            if (c != min && c != max) mid = c;
            else if (a != min && a != max) mid = a;
            else if (b != min && b != max) mid = b;
            else if (a == b) mid = a;
            else if (a == c) mid = a;
            else if (b == c) mid = b;

            if (min + mid == max)
             Console.WriteLine("{0} + {1} = {2}", min, mid, max);
            else
            Console.WriteLine("No");
          



        }
    }
}
