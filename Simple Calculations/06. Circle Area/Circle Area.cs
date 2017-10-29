using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Circle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            var perimeter = r * 2 * Math.PI;
            Console.Write("Area = ");
            Console.WriteLine(area);
            Console.Write("Perimeter = ");
            Console.WriteLine(perimeter);
        }
    }
}
