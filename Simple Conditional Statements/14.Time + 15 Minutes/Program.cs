using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = double.Parse(Console.ReadLine());
            var min = double.Parse(Console.ReadLine());
            if (min < 45)
            {
                var min2 = min + 15;
                Console.WriteLine(hours + ":" + min2);
            }
            else
            {
                hours++;
                var min2 = min + 15 - 60;
                if (hours == 24)
                {
                    hours = 0;
                    if (min2 < 10)
                    {
                        Console.WriteLine(hours + ":" + "0" + min2);
                    }
                    else
                    {
                        Console.WriteLine(hours + ":" + min2);
                    }
                }
                else
                {
                    if (min2 < 10)
                    {
                        Console.WriteLine(hours + ":" + "0" + min2);
                    }
                    else
                    {
                        Console.WriteLine(hours + ":" + min2);
                    }
                }
            }
        }
    }
}
