using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            var necessaryHours = int.Parse(Console.ReadLine());
            var numberWorkers = int.Parse(Console.ReadLine());
            var workDays = int.Parse(Console.ReadLine());

            var sum = numberWorkers * workDays * 8;

            if (sum > necessaryHours)
            {
                sum = sum - necessaryHours;
                Console.WriteLine("{0} hours left", sum);
            }
            else
            {
                sum = necessaryHours - sum;
                var penalty = sum * workDays;
                Console.WriteLine("{0} overtime", sum);
                Console.WriteLine("Penalties: {0}", penalty);
            }



        }
    }
}
