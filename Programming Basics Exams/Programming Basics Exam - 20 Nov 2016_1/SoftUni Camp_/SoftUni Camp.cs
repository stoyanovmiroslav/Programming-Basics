using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Camp_
{
    class Program
    {
        static void Main(string[] args)
        {
            var grups = int.Parse(Console.ReadLine());
            var allpeople = 0;
           var grup1 = 0;
            var grup2 = 0;
            var grup3 = 0;
            var grup4 = 0;
            var grup5 = 0;

            for (int i = 0; i < grups; i++)
            {
                var number = int.Parse(Console.ReadLine());
                allpeople = number + allpeople;
                if (number <= 5)
                {
                    grup1= number+grup1;
                }
                else if (number <=12)
                {
                    grup2 = number + grup2;

                }
                else if (number <=25)
                {
                    grup3 = number + grup3;

                }
                else if (number <=40)
                {
                    grup4 = number + grup4;

                }
                else if (number > 40)
                {
                    grup5 = number + grup5;

                }
            }
            Console.WriteLine("{0:f2}%", (double)grup1 / allpeople * 100);
            Console.WriteLine("{0:f2}%", (double)grup2 / allpeople * 100);
            Console.WriteLine("{0:f2}%", (double)grup3 / allpeople * 100);
            Console.WriteLine("{0:f2}%", (double)grup4 / allpeople * 100);
            Console.WriteLine("{0:f2}%", (double)grup5 / allpeople * 100);

        }
    }
}
