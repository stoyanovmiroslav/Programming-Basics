using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoredicaNarastvashtiElementi
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            var oldCount = 0;
            var oldNumber = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > oldNumber)
                {
                    count++;
                    if (count > oldCount)
                    {
                        oldCount = count;
                    }
                }
                else
                {
                  
                    count = 1;
                }
                oldNumber = number;
            }
            Console.WriteLine(oldCount);
        }
    }
}
