using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (number % 2 != 0)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    number = int.Parse(Console.ReadLine());
                    if (number % 2 == 0)
                    {
                        break;
                    }
                    Console.WriteLine("This number is not even.");
                }
                catch
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            Console.WriteLine("Even number entered: {0}", number);
        }
    }
}
