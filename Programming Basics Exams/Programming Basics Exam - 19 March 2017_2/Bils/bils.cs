using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bils
{
    class bils
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            var electric = 0.00;
            


            for (int i = 1; i <= month; i++)
            {
                var bills = double.Parse(Console.ReadLine());
                electric += bills;
            }
            var water = month * 20;
            var internet = month * 15;
           

            var sum = water + internet + electric;

            sum *= 1.2;

            var average = (electric + water + internet + sum) / month;

            Console.WriteLine("Electricity: {0:f2} lv", electric);
            Console.WriteLine("Water: {0:f2} lv", water);
            Console.WriteLine("Internet: {0:f2} lv", internet);
            Console.WriteLine("Other: {0:f2} lv", sum);
            Console.WriteLine("Average: {0:f2} lv", average);
           



        }
    }
}
