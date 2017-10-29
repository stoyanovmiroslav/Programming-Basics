using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            var fast = double.Parse(Console.ReadLine());

            if (fast <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (fast <= 50)
            {
                Console.WriteLine("average");
            }
            else if (fast <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (fast <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
