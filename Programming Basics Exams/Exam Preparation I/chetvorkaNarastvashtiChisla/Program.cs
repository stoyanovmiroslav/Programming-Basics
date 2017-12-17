using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chetvorkaNarastvashtiChisla
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var prov = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                for (int j = firstNumber; j <= secondNumber; j++)
                {
                    for (int k = firstNumber; k <= secondNumber; k++)
                    {
                        for (int l = firstNumber; l <= secondNumber; l++)
                        {

                            if (i < j && j < k && k< l )
                            {
                                Console.WriteLine("{0} {1} {2} {3}", i, j, k, l);
                                prov = 1;
                            }
                        }
                    }
                }
            }
            if (prov==0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
