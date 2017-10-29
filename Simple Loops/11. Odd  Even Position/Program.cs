using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddMin = 1000000000.0;
            var oddMax = -1000000000.0;
            var evenMin = 1000000000.0;
            var evenMax = -1000000000.0;
            var oddSum = 0.00;
            var evenSum = 0.00;

            for (int i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    if (num < evenMin)
                        evenMin = num;
                    if (num > evenMax)
                        evenMax = num;
                    evenSum += num;
                }
                else
                {
                    if (num < oddMin)
                        oddMin = num;
                    if (num > oddMax)
                        oddMax = num;
                    oddSum += num;
                }
            }
            Console.WriteLine("OddSum={0}", oddSum);

            if (oddMin == 1000000000.0)
                Console.WriteLine("OddMin=No");
            else
                Console.WriteLine("OddMin={0}", oddMin);

            if (oddMax == -1000000000.0)
                Console.WriteLine("OddMax=No");
            else
                Console.WriteLine("OddMax={0}", oddMax);

            Console.WriteLine("EvenSum={0}", evenSum);

            if (evenMin == 1000000000.0)
                Console.WriteLine("EvenMin=No");
            else
                Console.WriteLine("EvenMin={0}", evenMin);

            if (evenMax == -1000000000.0)
                Console.WriteLine("EvenMax=No");
            else
                Console.WriteLine("EvenMax={0}", evenMax);
        }
    }
}
