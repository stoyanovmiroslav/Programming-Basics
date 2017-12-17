using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generirashtoPravoygalnici
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var p = int.Parse(Console.ReadLine());
            var sum = 0;
            var add = 0;

            for (int left = -n; left <= 0; left++)
            {
                for (int top = -n; top <= 0; top++)
                {
                    for (int right = 0; right <= n; right++)
                    {
                        for (int bottom = 0; bottom <= n; bottom++)
                        {
                              if (-n <= left && left < right && right <= n )
                                {
                                int sideOne = Math.Abs(left) + Math.Abs(right);
                                int sideTwo = Math.Abs(top) + Math.Abs(bottom);

                                if (sideOne * sideTwo >= p)
                                {
                                    sum = sideOne*sideTwo;

                                    Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bottom, sum);
                                    add++;
                                }


                            }

                        }
                    }
                }
            }
            if (add == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
