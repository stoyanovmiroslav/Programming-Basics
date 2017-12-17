using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var reult = 0;

            for (int s1 = 1; s1 <= n; s1++)
            {
                if (s1 >= 9)
                    break;

                for (int s2 = 1; s2 <= n; s2++)
                {
                    if (s2 >= 9)
                        break;

                    for (int s3 = 1; s3 <= n; s3++)
                    {
                        if (s3 >= 9)
                            break;

                        for (int s4 = 1; s4 <= n; s4++)
                        {
                            if (s4 >= 9)
                                break;

                            for (int s5 = 1; s5 <= n; s5++)
                            {
                                if (s5 >= 9)
                                    break;
                                for (int s6 = 1; s6 <= n; s6++)
                                {
                                    if (s6 >= 9)
                                        break;
                                    if (s1 * s2 * s3 * s4 * s5 * s6 == n)
                                    {
                                        reult = 1;
                                        if (s1 <= 9 && s1 >= 0)
                                            Console.Write("{0}{1}{2}{3}{4}{5} ", s1, s2, s3, s4, s5, s6);
                                    }
                                }

                            }

                        }
                    }
                }

            }
            if (reult == 1)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("999999");
            }

        }
    }
}
