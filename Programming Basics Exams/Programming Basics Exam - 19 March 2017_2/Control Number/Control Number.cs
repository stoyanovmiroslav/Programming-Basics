using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var controlNumber = int.Parse(Console.ReadLine());
            var moves = 0;
            var sum = 0.00;
            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    moves++;
                    sum += i * 2 + j * 3;
                    if (sum >= controlNumber)
                    {
                        Console.WriteLine("{0} moves", moves);
                        Console.WriteLine($"Score: {sum} >= {controlNumber}");
                        return;
                    }
                 


                }
            }
             
                Console.WriteLine("{0} moves", moves);
           
        }
    }
}
