using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var b = 0;
            Console.Write(new string(' ', n + 1));
            Console.WriteLine("|");
            for (int i = 0; i < n; i++)
            {
                b = n - (i + 1);
                Console.Write(new string(' ', b));
                Console.Write(new string('*', i + 1));
                Console.Write(" ");
                Console.Write("|");
                Console.Write(" ");
                Console.WriteLine(new string('*', i + 1));
            }
        }
    }
}
