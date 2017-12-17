using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var poc1 = int.Parse(Console.ReadLine());
            var poc2 = int.Parse(Console.ReadLine());
            var maxBattle = int.Parse(Console.ReadLine());
            var max = 0;
            for (int i = 1; i <= poc1; i++)
            {
                for (int j = 1; j <= poc2; j++)
                {
                    Console.Write("({0} <-> {1}) ", i , j);
                    max++;
                    if (max == maxBattle)
                        return;

                 
                }
            }

        }
    }
}
