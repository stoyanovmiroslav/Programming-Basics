using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRooms
{
    class HotelRooms
    {
        static void Main(string[] args)
        {
            var mounth = Console.ReadLine();
            var number = int.Parse(Console.ReadLine());
            var studio = 0.00;
            var apartment = 0.00;
            var discount = 0.00;
            var discouthotel = 0.00;

            if (mounth == "May" || mounth == "October")
            {
                studio = 50;
                apartment = 65;
                if (number > 7 && number <= 14)
                {
                    discount = 0.05;
                }
                else if (number > 14)
                {
                    discount = 0.30;
                }

            }
            else if (mounth == "June" || mounth == "September")
            {
                studio = 75.20;
                apartment = 68.70;
                if (number > 14)
                {
                    discount = 0.20;
                }

            }
            else if ((mounth == "July" || mounth == "August"))
            {
                studio = 76;
                apartment = 77;
            }

            if (apartment != 0 && number > 14)
            {
                discouthotel = 0.10;
            }

            var pricestudio = number * studio;
            var pricejhotel = number * apartment;
            var discstudio = pricestudio * discount;
            var dischotel = pricejhotel * discouthotel;
            var stud = pricestudio - discstudio;
            var apart = pricejhotel - dischotel;
            Console.WriteLine($"Apartment: {apart:f2} lv.");
            Console.WriteLine($"Studio: {stud:f2} lv.");

        }
    }
}
