using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberAdilt = int.Parse(Console.ReadLine());
            var numberStudents = int.Parse(Console.ReadLine());
            var numberNights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            var transportAdult = 0.00;
            var transportStudents = 0.00;

            if (transport == "train")
            {
                if (numberAdilt + numberStudents >= 50)
                {
                    transportAdult = 24.99 - (24.99 * 0.5);
                    transportStudents = 14.99 - (14.99 *0.5);
                }
                else
                {
                    transportAdult = 24.99;
                    transportStudents = 14.99;
                }       
               
            }
            else if (transport == "bus")
            {
                transportAdult = 32.50;
                transportStudents = 28.50;

                
            }
            else if (transport == "boat")
            {
                transportAdult = 42.99;
                transportStudents = 39.99;
            }
            else if (transport == "airplane")
            {
                transportAdult = 70.00;
                transportStudents = 50.00;
            }

            var alltransport = (transportAdult * numberAdilt + transportStudents * numberStudents) * 2;

            var noshtuvki = numberNights * 82.99;

            var total = noshtuvki + alltransport;

            total = total + (total * 0.10);
            Console.WriteLine("{0:f2}", total);
        }
    }
}
