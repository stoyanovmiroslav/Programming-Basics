using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            #region firstHalf 
            var star = 1;
            if (n % 2 == 0)
                star = 2;

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                var tireta = (n - star) / 2;
                Console.Write(new string('-', tireta));
                Console.Write(new string('*', star));
                Console.WriteLine(new string('-', tireta));
                star = star + 2;
            }
            #endregion
            #region secondHalf
            for (int i = 0; i <= n / 2 - 1; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");
            }
            #endregion
        }
    }
}
