using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Number_0._._._100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            if (num > 100)
            { Console.Write("invalid number"); }
            else if (num < 0)
            { Console.Write("invalid number"); }
            else if (num == 100)
            { Console.Write("one hundred"); }
            else if (num >= 90)
            { Console.Write("ninety"); }
            else if (num >= 80)
            { Console.Write("eighty"); }
            else if (num >= 70)
            { Console.Write("seventy"); }
            else if (num >= 60)
            { Console.Write("sixty"); }
            else if (num >= 50)
            { Console.Write("fifty"); }
            else if (num >= 40)
            { Console.Write("forty"); }
            else if (num >= 30)
            { Console.Write("thirty"); }
            else if (num >= 20)
            { Console.Write("twenty"); }
            else if (num == 19)
            { Console.Write("nineteen"); }
            else if (num == 18)
            { Console.Write("eighteen"); }
            else if (num == 17)
            { Console.Write("seventeen"); }
            else if (num == 16)
            { Console.Write("sixteen"); }
            else if (num == 15)
            { Console.Write("fifteen"); }
            else if (num == 14)
            { Console.Write("forteen"); }
            else if (num == 13)
            { Console.Write("thirteen"); }
            else if (num == 12)
            { Console.Write("twelve"); }
            else if (num == 11)
            { Console.Write("eleven"); }
            else if (num == 0)
            { Console.WriteLine("zero"); }
            else if (num == 1)
                Console.WriteLine("one");
            else if (num == 2)
                Console.WriteLine("two");
            else if (num == 3)
                Console.WriteLine("three");
            else if (num == 4)
                Console.WriteLine("four");
            else if (num == 5)
                Console.WriteLine("five");
            else if (num == 6)
                Console.WriteLine("six");
            else if (num == 7)
                Console.WriteLine("seven");
            else if (num == 8)
                Console.WriteLine("eight");
            else if (num == 9)
                Console.WriteLine("nine");
            else if (num == 10)
            { Console.Write("ten"); }

            if (num < 100)
            {
                if (num > 19)
                {
                    if (num % 10 == 1)
                        Console.WriteLine(" one");
                    else if (num % 10 == 2)
                        Console.WriteLine(" two");
                    else if (num % 10 == 3)
                        Console.WriteLine(" three");
                    else if (num % 10 == 4)
                        Console.WriteLine(" four");
                    else if (num % 10 == 5)
                        Console.WriteLine(" five");
                    else if (num % 10 == 6)
                        Console.WriteLine(" six");
                    else if (num % 10 == 7)
                        Console.WriteLine(" seven");
                    else if (num % 10 == 8)
                        Console.WriteLine(" eight");
                    else if (num % 10 == 9)
                        Console.WriteLine(" nine");
                }
            }
        }
    }
}
