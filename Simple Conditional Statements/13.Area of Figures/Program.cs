using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var tipe = Console.ReadLine();
            if (tipe == "square")
            {
                var a = double.Parse(Console.ReadLine());
                var face = a * a;
                Console.WriteLine(Math.Round(face, 3));
            }
            else if (tipe == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var face = a * b;
                Console.WriteLine(Math.Round(face, 3));
            }
            else if (tipe == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                var face = Math.PI * (r * r);
                Console.WriteLine(Math.Round(face, 3));
            }
            else if (tipe == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var face = a * b / 2;
                Console.WriteLine(Math.Round(face, 3));
            }
        }
    }
}
