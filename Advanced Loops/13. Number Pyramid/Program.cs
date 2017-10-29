using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 1;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (col > 1)
                        Console.Write(" ");
                    Console.Write(sum);
                    sum++;
                    if (sum > n)
                        break;
                }
                Console.WriteLine();
                if (sum > n)
                    break;
            }
        }
    }
}
