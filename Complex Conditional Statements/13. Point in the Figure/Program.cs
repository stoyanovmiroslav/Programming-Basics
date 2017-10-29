using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var x1 = 0; var x2 = h * 3;
            var y1 = 0; var y2 = h;
            var x3 = h; var x4 = h * 2;
            var y3 = h; var y4 = 4 * h;

            bool borderR1 = ((x == x1 || x == x2) && (y >= y1 && y <= y2)) || ((y == y1 || y == y2) && (x >= x1 && x <= x2));
            bool borderR2 = ((x == x3 || x == x4) && (y >= y3 && y <= y4)) || ((y == y3 || y == y4) && (x >= x3 && x <= x4));
            bool border = borderR1 || borderR2;

            bool rectangle1 = (x > x1 && x < x2) && (y > y1 && y < y2);
            bool rectangle2 = (x > x3 && x < x4) && (y > y3 && y < y4);
            bool inside = rectangle1 || rectangle2;
            bool pointBetween = (y == h && (x > h && x < h * 2));

            if (border && !pointBetween)
                Console.WriteLine("border");
            else if (pointBetween)
                Console.WriteLine("inside");
            else if (inside)
                Console.WriteLine("inside");
            else
                Console.WriteLine("outside");
        }
    }
}
