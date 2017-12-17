using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayAfter5days
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            int dayOfMonths = 31;

            if (month ==2)
            {
                dayOfMonths = 28;
            }
            else if (month == 4 || month == 6 ||month == 9 || month == 11)
            {
                dayOfMonths = 30;
            }

            var dayout = day + 5;
            if (dayout > dayOfMonths)
            {
                if (month+1 <=12)
                {
                    dayout = dayout - dayOfMonths;
                    Console.WriteLine("{0}.{1:00}", dayout, month + 1);
                }
                else
                {
                    dayout = dayout - dayOfMonths;
                    Console.WriteLine("{0}.{1:00}", dayout, month = 1);
                }
                 
            }
            else
            {
               Console.WriteLine("{0}.{1:00}", dayout, month );

            }

        }
    }
}
