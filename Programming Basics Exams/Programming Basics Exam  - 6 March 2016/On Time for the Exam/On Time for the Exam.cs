using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursExam = int.Parse(Console.ReadLine());
            var minExam = int.Parse(Console.ReadLine());
            var hoursComing = int.Parse(Console.ReadLine());
            var minComing = int.Parse(Console.ReadLine());
            var h = 0;

            var toMinExamp = hoursExam * 60 + minExam;
            var toMinComing = hoursComing * 60 + minComing;
            var diffMin = toMinExamp - toMinComing;

            if (diffMin == 0)
            {
                Console.WriteLine("On time");
            }
            else if (diffMin <= 30 && diffMin > 0)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", diffMin);
            }
            else if (diffMin > 30)
            {

                while (diffMin >= 60)
                {
                    h++;
                    diffMin -= 60;
                }
                if (h != 0)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:{1:00} hours before the start", h, diffMin);
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", diffMin);
                }
            }
            else
            {
                diffMin = Math.Abs(diffMin);
                for (int i = diffMin; i >= 60; i = diffMin)
                {
                    h++;
                    diffMin -= 60;
                }

                if (h != 0)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:{1:00} hours after the start", h, diffMin);
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0} minutes after the start", diffMin);
                }

            }



        }
    }
}
