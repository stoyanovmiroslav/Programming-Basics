using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_OperationBetweenNumbers
{
    class Assessment_OperationBetweenNumbers
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var operation = Console.ReadLine();
            var result = 0.00;
            if (operation == "+" || operation == "-" || operation == "*")
            {
                if (operation == "+")
                {
                    result = n1 + n2;
                }
                else if (operation == "-")
                {
                    result = n1 - n2;
                }
                else if (operation == "*")
                {
                    result = (double)n1 * n2;
                }

                var endresult = result % 2;
                if (endresult == 0)
                    Console.WriteLine($"{n1} {operation} {n2} = {result} - even");
                else
                    Console.WriteLine($"{n1} {operation} {n2} = {result} - odd");
            }

            else if (operation == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = n1 / (double)n2;
                    Console.WriteLine($"{n1} {operation} {n2} = {result:f2}");
                }
            }
            else if (operation == "%")
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = n1 % n2;
                    Console.WriteLine($"{n1} {operation} {n2} = {result}");
                }


            }
        }
    }
}
