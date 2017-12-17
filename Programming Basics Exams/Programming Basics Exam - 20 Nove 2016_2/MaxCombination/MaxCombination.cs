using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombinations
{
    class MaxCombinations
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int maxCombinations = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int i = n1; i <= n2; i++)
            {
                for (int j = n1; j <= n2; j++)
                {
                    if (counter > maxCombinations)
                    {
                        break;
                    }
                    Console.Write("<{0}-{1}>", i, j);
                    counter += 1;


                }
            }

        }
    }
}