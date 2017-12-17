using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var point = 0.00;
            var numberPercent = 0.00;
            var to9 = 0.00;
            var to19 = 0.00;
            var to29 = 0.00;
            var to39 = 0.00;
            var to50 = 0.00;
            var invalid = 0.00;

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number >= 0 && number <= 9)
                {
                    to9++;
                    numberPercent = number * 0.2;
                    point = point + numberPercent;
                }
                else if (number >= 10 && number <= 19)
                {
                    to19++;
                    numberPercent = number * 0.3;
                    point = point + numberPercent;
                }

                else if (number >= 20 && number <= 29)
                {
                    to29++;
                    numberPercent = (double)number * 0.4;
                    point = point + numberPercent;
                }
                else if (number >= 30 && number <= 39)
                {
                    to39++;
                    point += 50;
                }
                else if (number >= 40 && number <= 50)
                {
                    to50++;
                    point += 100;
                }
                else 
                {
                    invalid++;
                    point /= 2;
                }
            }

            Console.WriteLine("{0:f2}", point);
            to9 = to9 / n * 100;
            to19 = to19 / n * 100;
            to29 = to29 / n * 100;
            to39 = to39 / n * 100;
            to50 = to50 / n * 100;
            invalid = invalid / n * 100;



            Console.WriteLine("From 0 to 9: {0:f2}%",   to9);
            Console.WriteLine("From 10 to 19: {0:f2}%", to19);
            Console.WriteLine("From 20 to 29: {0:f2}%", to29);
            Console.WriteLine("From 30 to 39: {0:f2}%", to39);
            Console.WriteLine("From 40 to 50: {0:f2}%", to50);
            Console.WriteLine("Invalid numbers: {0:f2}%", invalid);

            
            
            
            
            
            

        }
    }
}
