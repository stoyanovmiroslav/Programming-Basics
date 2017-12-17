using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class catTom
    {
        static void Main(string[] args)
        {
            var kvLoze = int.Parse(Console.ReadLine());
            var greep1kv = double.Parse(Console.ReadLine());
            var needwine = int.Parse(Console.ReadLine());
            var nwokers = int.Parse(Console.ReadLine());

            var proizvinokv = kvLoze * 40 / 100;
            var lozeforwino = proizvinokv * greep1kv;
            var litvino = lozeforwino / 2.5;

            if (litvino < needwine)
            {
                var needmore = Math.Truncate(needwine - litvino);
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", needmore);
            }
            else
            {
                var morewine = Math.Ceiling(litvino - needwine);
                var perpeson = Math.Ceiling(morewine / nwokers);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Truncate(litvino));
                Console.WriteLine("{0} liters left -> {1} liters per person.", morewine, perpeson);
            }



        }
    }
}
