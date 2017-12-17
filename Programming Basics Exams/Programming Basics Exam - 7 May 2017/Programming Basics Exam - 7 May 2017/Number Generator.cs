using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Basics_Exam___7_May_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            var specNumber = int.Parse(Console.ReadLine());
            var controlNumber = int.Parse(Console.ReadLine());
            for (int i = m; i >= 1; i--)
            {
                if (specNumber >= controlNumber)
                    break;
                for (int j = n; j >= 1; j--)
                {
                    if (specNumber >= controlNumber)
                    break;
                    
                    for (int k = l; k >= 1; k--)
                    {
                        var number = int.Parse($"{i}{j}{k}");
                        
                        if (number % 3 == 0)
                        {
                            specNumber += 5;
               	
         }
                        else if (number % 10 ==5)
                        {
                            specNumber -= 2;
                        }
                        else if (number % 2 == 0)
                        {
                            specNumber *= 2;
                        }

                        if (specNumber >= controlNumber)
                        {
                            break;
                        }
                    }

                }

            }
            if (specNumber>=controlNumber)
            {
                Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specNumber);

            }else
                Console.WriteLine("No! {0} is the last reached special number.", specNumber);

        }
    }
}
