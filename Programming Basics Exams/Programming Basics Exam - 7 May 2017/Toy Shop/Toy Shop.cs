using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var holidayMoney = double.Parse(Console.ReadLine());
            var toys1 = double.Parse(Console.ReadLine());
            var toys2 = double.Parse(Console.ReadLine());
            var toys3 = double.Parse(Console.ReadLine());
            var toys4 = double.Parse(Console.ReadLine());
            var toys5 = double.Parse(Console.ReadLine());
            var percent = 0.00;
            var numberOrders = toys1 + toys2 + toys3 + toys4 + toys5;
            if (numberOrders >= 50)
            percent = 0.25;
            
            toys1 *= 2.60;
            toys2 *= 3;
            toys3 *= 4.10;
            toys4 *= 8.2;
            toys5 *= 2;
            var toyssum = toys1 + toys2 + toys3 + toys4 + toys5;
            var toyspercent = percent * toyssum;
            var leftToysum = toyssum - toyspercent;
            var result = leftToysum * 0.10;
            result = leftToysum - result;
               

            if (result >= holidayMoney)
            {
                result = result - holidayMoney;
                Console.WriteLine($"Yes! {result:f2} lv left.");
            }
            else
            {
                result = holidayMoney - result;
                Console.WriteLine($"Not enough money! {result:f2} lv needed.");
            }



        }
    }
}
