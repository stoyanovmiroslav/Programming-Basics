using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', a));
            for (int i = 0; i < a - 2; i++)
            {
                Console.WriteLine(new string('*', 1) + new string(' ', a - 2) + new string('*', 1));
            }
            Console.WriteLine(new string('*', a));
        }
    }
}
