using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}",
                         new string('.', n + 1),
                         new string('_', n * 2 + 1));

            #region firstHalf
            var plus2 = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(@"{0}//{1}\\{0}",
                         new string('.', (n + 1) - i),
                         new string('_', (n * 2 - 1) + plus2));
                plus2 += 2;
            }
            #endregion
            Console.WriteLine(@"//{0}STOP!{0}\\",
                         new string('_', ((n * 4 + 3) - 9) / 2));

            #region secondHalf
            var plusS2 = 0;
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine(@"{0}\\{1}//{0}",
                         new string('.', i),
                         new string('_', ((n * 4 + 3) - 4) - plusS2));
                plusS2 += 2;
            }
            #endregion
        }
    }
}
