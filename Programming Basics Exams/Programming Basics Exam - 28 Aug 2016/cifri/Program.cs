using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cifri
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var tirthN = n % 10;
            var second = n / 10;
            var secondN = second % 10;
            var firstN = second / 10;
            
          // Console.WriteLine(firstN);
          // Console.WriteLine(secondN);
          // Console.WriteLine(tirthN);
            for (int i = 0; i < firstN + secondN; i++)
            {
                for (int j = 0; j < firstN + tirthN; j++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - firstN;
                    }
                    else if (n % 3== 0)
                    {
                        n = n - secondN;
                    }
                    else 
                    {
                        n = n + tirthN;
                    }
                    Console.Write("{0} ", n);
                }
                Console.WriteLine();
            }

          

        }
    }
}
