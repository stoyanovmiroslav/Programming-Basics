using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var MidDishes = 1;
            var leftRightDishes = 0;
            var minus2 = 0;
            if (n % 2 == 0)
                MidDishes = 2;
   
            #region firstHalf

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                leftRightDishes = ((n - 1) / 2) - i;
                Console.Write(new string('-', leftRightDishes));
                if (n % 2 == 0 && i == 0)
                Console.Write("*");
                else if (i != 0)
                Console.Write("*");
                if (i != 0)
                Console.Write(new string('-', MidDishes));
                Console.Write("*");
                Console.WriteLine(new string('-', leftRightDishes));
                if (i != 0)
                MidDishes += 2;
            }
            #endregion

            #region secondHalf
            for (int i = 1; i <= (n-1) / 2; i++)
            {
                var MidDishesSecond = n - 4 - minus2;
                leftRightDishes = i;
                Console.Write(new string('-', leftRightDishes));
                if (n % 2 == 0 && i == (n - 1) / 2)
                Console.Write("*");
                else if (i != (n - 1) / 2)
                Console.Write("*");
                if (i != (n - 1) / 2)
                Console.Write(new string('-', MidDishesSecond));
                Console.Write("*");
                Console.WriteLine(new string('-', leftRightDishes));
                minus2 += 2;
            }
            #endregion



        }
    }
}
