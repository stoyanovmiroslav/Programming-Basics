using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var foodNeed = int.Parse(Console.ReadLine());
            var dogFoodDay = double.Parse(Console.ReadLine());
            var catFoodDay = double.Parse(Console.ReadLine());
            var turtleFoodDay = double.Parse(Console.ReadLine());

            var allFood = (dogFoodDay + catFoodDay + (turtleFoodDay/1000)) * days;
            if (allFood <= foodNeed)
            {
                allFood = Math.Floor(foodNeed - allFood);
                Console.WriteLine($"{allFood} kilos of food left.");
            }
            else
            {
                allFood = Math.Ceiling(allFood - foodNeed);
                Console.WriteLine($"{allFood} more kilos of food are needed.");
            }


        }
    }
}
