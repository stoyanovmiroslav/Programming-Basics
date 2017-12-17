using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remontnaplochki
{
    class Program
    {
        static void Main(string[] args)
        {
            var rabdni = double.Parse(Console.ReadLine());
            var izkaranipari = double.Parse(Console.ReadLine());
            var comision = double.Parse(Console.ReadLine());

            var monthsalary = rabdni * izkaranipari;
            var bunus = monthsalary * 2.5;
            var yearsalarys = monthsalary * 12 + bunus;

            var tax = (yearsalarys / 100) * 25;
            var aftertax = yearsalarys - tax;
            var leva = aftertax * comision;
            var total = leva / 365;

            Console.WriteLine("{0:f2}", total);


        }
    }
}
