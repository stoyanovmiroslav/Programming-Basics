using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 0;

            for (int row = 0; row < n; row++)
            {
                var minus = 2;
                for (int col = 1; col <= n; col++)
                {
                    num = col + row;
                    if (num > n)
                    {
                        num = num - minus;
                        minus += 2;
                    }
                    Console.Write("{0} ", num);
                }
                Console.WriteLine();
            }
        }
    }
}
