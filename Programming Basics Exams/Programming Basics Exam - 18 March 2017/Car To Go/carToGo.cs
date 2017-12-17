using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_To_Go
{
    class carToGo
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var classCar = "";
            var Car = "";
            var persent = 0.00;


            if (budget <= 100)
            {
                classCar = "Economy class";
                if (season == "Summer")
                {
                    Car = "Cabrio";
                    persent = 0.35;
                }
                else
                {
                    Car = "Jeep";
                    persent = 0.65;
                }
            }
            else if (budget > 100 && budget <=500)
            {
                classCar = "Compact class";
                if (season == "Summer")
                {
                    Car = "Cabrio";
                    persent = 0.45;
                }
                else
                {
                    Car = "Jeep";
                    persent = 0.80;
                }

            }
            else if (budget > 500)
            {
                classCar = "Luxury class";
               Car = "Jeep";
               persent = 0.90;
            }

            var price = budget * persent;

            Console.WriteLine(classCar);
            Console.WriteLine("{0} - {1:f2}", Car, price );
          
        }
    }
}
