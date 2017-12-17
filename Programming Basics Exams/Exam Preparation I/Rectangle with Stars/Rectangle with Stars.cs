using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_with_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
      Console.WriteLine("{0}", new string ('%' , 2 * n));

            for (int i = 0; i < (n-1)/2; i++)
            {
                Console.WriteLine("%{0}%", new string(' ', 2 * n -2));
            }

      Console.WriteLine("%{0}**{0}%", new string(' ', (2 * n - 4)/2));

            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.WriteLine("%{0}%", new string(' ', 2 * n - 2));
            }

      Console.WriteLine("{0}", new string('%', 2 * n));

        }
    }
}
