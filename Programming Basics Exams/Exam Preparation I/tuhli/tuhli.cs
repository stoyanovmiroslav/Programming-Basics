using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuhli
{
    class tuhli
    {
        static void Main(string[] args)
        {
            var numberTuhli = int.Parse(Console.ReadLine());
            var numberWorkers = int.Parse(Console.ReadLine());
            var carCapacity = int.Parse(Console.ReadLine());

            var kurs = numberWorkers * carCapacity;
            var sum = (double)numberTuhli / kurs;
              sum =  Math.Ceiling(sum);
            Console.WriteLine(sum);

        }
    }
}
