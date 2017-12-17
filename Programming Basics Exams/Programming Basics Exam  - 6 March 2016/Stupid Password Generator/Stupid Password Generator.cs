using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupid_Password_Generator__
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
        
            for (int i = 1; i <= num1; i++)
            {
                for (int j = 1; j <= num1; j++)
                {
                    for (int k = 97; k < 97 + num2; k++)
                    {
                        for (int l = 97; l < 97+ num2; l++)
                        {
                            for (int m = 1; m <= num1; m++)
                            {
                                if (m > i && m > j)
                                {
                                    Console.Write("{0}{1}{2}{3}{4} ", i, j, (char)k, (char)l, m);

                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();

        }
    }
}
