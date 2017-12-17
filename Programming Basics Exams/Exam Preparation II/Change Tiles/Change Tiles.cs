using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var wideFloor = double.Parse(Console.ReadLine());
            var longFloor = double.Parse(Console.ReadLine());
            var sideTriangle = double.Parse(Console.ReadLine());
            var heightTriangle = double.Parse(Console.ReadLine());
            var priceTail = double.Parse(Console.ReadLine());
            var moneyMaster = double.Parse(Console.ReadLine());

            var floor = wideFloor * longFloor;
            var tail = sideTriangle * heightTriangle / 2;
            var needTail = Math.Ceiling(floor / tail) + 5;

            var moneyNeed = needTail * priceTail + moneyMaster;

            if (moneyNeed > money)
            {
                moneyNeed = moneyNeed - money;
                Console.WriteLine($"You'll need {moneyNeed:f2} lv more.");
            }
            else
            {
                moneyNeed =  money - moneyNeed;
                Console.WriteLine($"{moneyNeed:f2} lv left.");
            }

 

        }
    }
}
