using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Price
{
    class House_Price
    {
        static void Main(string[] args)
        {
            var lessRoom = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine());
            var pricekv2 = double.Parse(Console.ReadLine());

            var secondRoom = lessRoom + (lessRoom * 0.1);
            var tirthRoom = secondRoom + (secondRoom * 0.1);
            var bathroom = lessRoom / 2;
            var obshtaPlosht = lessRoom + secondRoom + tirthRoom + kitchen + bathroom;
            var per5 = obshtaPlosht + (obshtaPlosht * 0.05);
            var sum = per5 * pricekv2;
            Console.WriteLine("{0:f2}",sum);

            
        }
    }
}
