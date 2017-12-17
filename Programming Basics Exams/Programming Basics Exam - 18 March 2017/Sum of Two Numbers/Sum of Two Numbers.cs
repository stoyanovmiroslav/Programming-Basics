using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var magic = int.Parse(Console.ReadLine());

            var comb = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    comb++;
                    if (i + j == magic)
                    {
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", comb, i , j , magic);
                        return;
                    }

                }
            }
            Console.WriteLine("{0} combinations - neither equals {1}", comb, magic);
        }
    }
}
