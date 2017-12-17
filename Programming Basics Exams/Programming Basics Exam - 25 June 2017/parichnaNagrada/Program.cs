using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parichnaNagrada
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var moneyPoint = double.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 1; i <= n; i++)
            {
              var point = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    point = point * 2;
                }

                sum = sum + point;
            }
            var result = sum * moneyPoint;
            Console.WriteLine("The project prize was {0:f2} lv.", result);
        }
    }
}
