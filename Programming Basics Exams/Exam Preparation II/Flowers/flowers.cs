using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class flowers
    {
        static void Main(string[] args)
        {
            var hrizantemi = int.Parse(Console.ReadLine());
            var rose = int.Parse(Console.ReadLine());
            var laleta = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var holydayOrNot = Console.ReadLine();
            var persent = 0.00;
            var hrizantemeP = 0.00;
            var roziP = 0.00;
            var laletaP = 0.00;

            if (season == "Spring")
            {
                if (laleta > 7)
                {
                    persent = 0.05;
                }
                hrizantemeP = 2.00;
                roziP = 4.10;
                laletaP = 2.50;
            }
            else if (season == "Summer")
            {
                persent = 0.00;

                hrizantemeP = 2.00;
                roziP = 4.10;
                laletaP = 2.50;

            }
            else if (season == "Autumn")
            {
                persent = 0.00;
                hrizantemeP = 3.75;
                roziP = 4.50;
                laletaP = 4.15;
            }
            else if (season == "Winter")
            {
                if (rose >= 10)
                {
                    persent = 0.10;
                }
                hrizantemeP = 3.75;
                roziP = 4.50;
                laletaP = 4.15;
            }
            var buketPrice = (rose * roziP) + (hrizantemi * hrizantemeP) + (laleta * laletaP);
            if (holydayOrNot == "Y")
                buketPrice = buketPrice + (buketPrice * 0.15);

            buketPrice = buketPrice - (buketPrice * persent);

            if (rose+ hrizantemi+laleta  > 20)
            {
                persent = 0.20;
                buketPrice = buketPrice - (buketPrice * persent);
            }

            Console.WriteLine("{0:f2}", buketPrice + 2);
   

           







        }
    }
}
