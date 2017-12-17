using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfDays = int.Parse(Console.ReadLine());
            var numberOfDancers = int.Parse(Console.ReadLine());
            var energy = 0.00;
            var eneryForAllDays = 0.00;
            for (int i = 1; i <= numberOfDays; i++)
            {
                var hours = int.Parse(Console.ReadLine());

                if (i % 2 == 0 && hours % 2 ==0 )
                {
                    energy = numberOfDancers * 68;
                }
                else if (i % 2 != 0 && hours % 2 == 0)
                {
                    energy = numberOfDancers *  49;
                }
                else if (i % 2 == 0 && hours % 2 != 0)
                {
                    energy = numberOfDancers * 65;
                }
                else if (i % 2 != 0 && hours % 2 != 0)
                {
                    energy = numberOfDancers * 30;
                }
                eneryForAllDays = energy + eneryForAllDays;
               
            }

            var totalEnergy = numberOfDancers * numberOfDays * 100;
            var energyEnd = totalEnergy - eneryForAllDays;
            var result = energyEnd / numberOfDancers / numberOfDays;

            if (result <= 50)
            {
                Console.WriteLine("They are wasted! Energy left: {0:f2}", result);

            }
            else
            {
                Console.WriteLine("They feel good! Energy left: {0:f2}", result);
            }

        }
    }
}
