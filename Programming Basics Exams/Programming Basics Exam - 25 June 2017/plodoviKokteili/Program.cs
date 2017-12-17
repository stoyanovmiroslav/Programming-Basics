using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plodoviKokteili
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruits = Console.ReadLine();
            var size = Console.ReadLine();
            var number = int.Parse(Console.ReadLine());
            var price = 0.00;

            if (fruits == "Watermelon" && size == "small") price = 2 * 56;
            else if (fruits == "Watermelon" && size == "big") price =5* 28.70;
            else if (fruits == "Mango" && size == "small") price = 2 * 36.66;
            else if (fruits == "Mango" && size == "big") price = 5 * 19.60;
            else if (fruits == "Pineapple" && size == "small") price = 2 * 42.10;
            else if (fruits == "Pineapple" && size == "big") price = 5 * 24.80;
            else if (fruits == "Raspberry" && size == "small") price = 2 * 20;
            else if (fruits == "Raspberry" && size == "big") price = 5 * 15.20;

            var pricePer = 0.00;
            price = price * number;

            if (price > 1000)
            {
                pricePer = price * 50 / 100;
            }
            else if (price >= 400 && price <= 1000)
            {
                pricePer = price * 15 / 100;

            }
            price = price - pricePer;
            Console.WriteLine("{0:f2} lv.", price);






        }
    }
}
