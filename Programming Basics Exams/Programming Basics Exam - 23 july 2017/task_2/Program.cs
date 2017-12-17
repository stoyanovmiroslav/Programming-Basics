using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberSteps = int.Parse(Console.ReadLine());
            var numberOfDencers = int.Parse(Console.ReadLine());
            var numbersOfDays = int.Parse(Console.ReadLine());
            
            var stepPerDay = numberSteps / numbersOfDays;

            var persentForAll = Math.Ceiling(stepPerDay / (double)numberSteps * 100);

            var perDancer = persentForAll / numberOfDencers;

            if (persentForAll <= 13)
            {
                Console.WriteLine("Yes, they will succeed in that goal! {0:f2}%.", perDancer);
            }
            else
            {
                Console.WriteLine("No, They will not succeed in that goal! Required {0:f2}% steps to be learned per day." , zavsekiTancior);
            }

        }
    }
}
