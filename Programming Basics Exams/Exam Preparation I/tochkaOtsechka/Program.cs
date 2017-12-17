using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tochkaOtsechka
{
    class Program
    {
        static void Main(string[] args)
     {
       var first = int.Parse(Console.ReadLine());
       var second = int.Parse(Console.ReadLine());
      var last = int.Parse(Console.ReadLine());

            if (last >= second && last <= first || last >= first && last <= second)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
           
                var distance1 = Math.Abs(second - last);
                var distance2 = Math.Abs(first - last);
                var total = Math.Min(distance1, distance2);

                Console.WriteLine(total);

            

        }
    }
}
