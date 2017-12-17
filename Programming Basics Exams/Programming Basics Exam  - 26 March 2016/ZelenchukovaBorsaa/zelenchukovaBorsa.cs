using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZelenchukovaBorsaa
{
    class zelenchukovaBorsa
    {
        static void Main(string[] args)
        {
            var vegetablePrice = double.Parse(Console.ReadLine());
            var frutsPrice = double.Parse(Console.ReadLine());
            var vegetableKg = double.Parse(Console.ReadLine());
            var frutsKg = double.Parse(Console.ReadLine());

            var vegetable = vegetableKg * vegetablePrice;
            var fruts = frutsKg * frutsPrice;
            var result = (vegetable + fruts) / 1.94;
            Console.WriteLine(result);


        }
    }
}
