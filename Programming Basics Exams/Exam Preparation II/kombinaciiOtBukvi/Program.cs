using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kombinaciiOtBukvi
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            var comb = 0;

            for (char i = a; i <= b ; i++)
            {
                for (char j = a; j <= b; j++)
                {
                    for (char k = a; k <= b; k++)
                    {
                        if (i != c && j !=c && k !=c)
                        {
                            Console.Write("{0}{1}{2} ", i, j, k);
                            comb++;
                        }

                    }
                }
            }
            Console.WriteLine(comb);

        }
    }
}
