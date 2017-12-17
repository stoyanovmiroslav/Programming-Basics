using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            var adulds = int.Parse(Console.ReadLine());
            var srudent = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            var hotel = nights * 82.99;

            if (transport == "bus")
            {
                var adultstrans = 32.50 * adulds;
                var studentstrans = 28.50 * srudent;
                var transcena = (adultstrans + studentstrans) * 2;
                var camission = (transcena + hotel) * 0.10;
                var total = transcena + hotel + camission;
                Console.WriteLine("{0:f2}", total);
            }
            else if (transport == "train")
            {
                if (adulds + srudent >= 50)
                {
                    var adultstrans = 24.99 * adulds / 2;
                    var studentstrans = 14.99 * srudent / 2;
                    var transcena = (adultstrans + studentstrans) * 2;
                    var camission = (transcena + hotel) * 0.10;
                    var total = transcena + hotel + camission;
                    Console.WriteLine("{0:f2}", total);
                }
                else
                {
                    var adultstrans = 24.99 * adulds;
                    var studentstrans = 14.99 * srudent;
                    var transcena = (adultstrans + studentstrans) * 2;
                    var camission = (transcena + hotel) * 0.10;
                    var total = transcena + hotel + camission;
                    Console.WriteLine("{0:f2}", total);
                }

            }
            else if (transport == "boat")
            {
                var adultstrans = 42.99 * adulds;
                var studentstrans = 39.99 * srudent;
                var transcena = (adultstrans + studentstrans) * 2;
                var camission = (transcena + hotel) * 0.10;
                var total = transcena + hotel + camission;
                Console.WriteLine("{0:f2}", total);
            }
            else if (transport == "airplane")
            {
                var adultstrans = 70.00 * adulds;
                var studentstrans = 50.00 * srudent;
                var transcena = (adultstrans + studentstrans) * 2;
                var camission = (transcena + hotel) * 0.10;
                var total = transcena + hotel + camission;
                Console.WriteLine("{0:f2}", total);
            }



        }
    }
}
