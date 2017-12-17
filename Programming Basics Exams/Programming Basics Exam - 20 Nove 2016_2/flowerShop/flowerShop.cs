using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flowerShop
{
    class flowerShop
    {
        static void Main(string[] args)
        {
            var magnolii = int.Parse(Console.ReadLine());
            var zumbili = int.Parse(Console.ReadLine());
            var rozi = int.Parse(Console.ReadLine());
            var kaktusi = int.Parse(Console.ReadLine());
            var PricePresent = double.Parse(Console.ReadLine());

            var sum = magnolii * 3.25 + zumbili * 4 + rozi * 3.5 + kaktusi * 8;
            sum = sum - (sum * 0.05);

            if (sum >= PricePresent)
            {
                sum = sum - PricePresent;
                Console.WriteLine("She is left with {0} leva.", Math.Floor(sum));
            }
            else
            {
                sum = PricePresent - sum;
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(sum));
            }


        }
    }
}
