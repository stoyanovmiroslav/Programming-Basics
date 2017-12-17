using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfDencer = int.Parse(Console.ReadLine());
            var numberOfPoint = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var place = Console.ReadLine();
            var point = 0.00;
            var outcome = 0.00;
            if (place == "Bulgaria")
            {
                point = numberOfPoint * numberOfDencer;
                if (season == "summer") outcome = 0.05;
                else if (season == "winter") outcome = 0.08;
                
            }
            else if (place == "Abroad")
            {
                point = numberOfPoint * numberOfDencer;
                point = point + (point * 0.5);
                if (season == "summer") outcome = 0.10;
                else if (season == "winter") outcome = 0.15;
            }

            var afterOutcome = point - (point * outcome);

            var charity = afterOutcome - (afterOutcome * 0.75);
            var charityFinal = afterOutcome * 0.75;
            var result = charity / numberOfDencer;

            Console.WriteLine("Charity - {0:f2}", charityFinal);
            Console.WriteLine("Money per dancer - {0:f2}", result);
        }
    }
}
