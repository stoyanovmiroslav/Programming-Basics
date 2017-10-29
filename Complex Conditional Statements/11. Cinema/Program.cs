using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var projects = Console.ReadLine().ToLower();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var price = 0d;

            if (projects == "premiere") price = 12;
            else if (projects == "normal") price = 7.5;
            else if (projects == "discount") price = 5;
            Console.WriteLine("{0:f2}", price * r * c);
        }
    }
}
