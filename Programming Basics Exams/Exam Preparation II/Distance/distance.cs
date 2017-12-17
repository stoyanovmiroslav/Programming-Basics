using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class distance
    {
        static void Main(string[] args)
        {
            var firstSpeed = int.Parse(Console.ReadLine());
            var firstTime = int.Parse(Console.ReadLine());
            var secondTime = int.Parse(Console.ReadLine());
            var tirthTime = int.Parse(Console.ReadLine());

            var firstToHour = (double)firstTime / 60;
            var secondToHour = (double)secondTime / 60;
            var tirthToHour = (double)tirthTime / 60;

            var time1 = firstSpeed * firstToHour;
            var up10per = firstSpeed +(firstSpeed* 0.10) ;
            var time2 = up10per * secondToHour;
            var down5per = up10per - (up10per * 0.05);
            var time3 = down5per * tirthToHour;
           
            Console.WriteLine("{0:f2}",time1+time2+time3);



        }
    }
}
