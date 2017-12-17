using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            var top = 0.00;
            var between4To499 = 0.00;
            var between3To399 = 0.00;
            var lessThan3 = 0.00;
            var uspeh = 0.00;

            for (int i = 0; i < numberOfStudents; i++)
            {
                var assessment = double.Parse(Console.ReadLine());
                if (assessment >= 5) top++;
                else if (assessment >= 4.00 && assessment <= 4.99) between4To499++;
                else if (assessment >= 3.00 && assessment <= 3.99) between3To399++;
                else if (assessment >= 2.00 && assessment <= 2.99) lessThan3++;

                uspeh = uspeh + assessment;

           }
            top = top / numberOfStudents * 100;
            between4To499 = between4To499 / numberOfStudents * 100;
            between3To399 = between3To399 / numberOfStudents * 100;
            lessThan3 = lessThan3 / numberOfStudents * 100;

            Console.WriteLine($"Top students: {top:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {between4To499:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {between3To399:f2}%");
            Console.WriteLine($"Fail: {lessThan3:f2}%");
            Console.WriteLine("Average: {0:f2} ", uspeh / numberOfStudents);

        }
    }
}

