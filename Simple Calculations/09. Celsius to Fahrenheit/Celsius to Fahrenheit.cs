using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());
            var fromCtoF = (1.8 * celsius) + 32;
            Console.WriteLine(Math.Round(fromCtoF, 2));
        }
    }
}
