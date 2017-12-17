using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var a = double.Parse(Console.ReadLine());

            var hallSize = (l * 100) * (w * 100);
            var wardrobe = a * 100;
            var wardrobeSize = wardrobe * wardrobe;
            var peika = hallSize / 10;
            var freeSpace = hallSize - (wardrobeSize + peika);
            var sum = freeSpace / (40 + 7000);
            Console.WriteLine("{0}", Math.Floor(sum));
        }
    }
}
