using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLily
{
    class SmartLily
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var pricewashingmashine = double.Parse(Console.ReadLine());
            var toyprice = double.Parse(Console.ReadLine());
            var toynum = 0.00;
            var sum = 0.00;
            var sumbirthday = 0.00;
            var brat = 0.00;
            var finish = 0.00;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    brat++;
                    sumbirthday += 10;
                    sum += sumbirthday;
                }
                else
                {
                    toynum++;

                }

            }
            var toytotal = toynum * toyprice;
            var totalpari = toytotal + sum - brat;

            if (pricewashingmashine > totalpari)
            {
                finish = pricewashingmashine - totalpari;
                Console.WriteLine("No! {0:f2}", finish);
            }
            else
            {
                finish = totalpari - pricewashingmashine;
                Console.WriteLine("Yes! {0:f2}", finish);
            }


        }
    }
}
