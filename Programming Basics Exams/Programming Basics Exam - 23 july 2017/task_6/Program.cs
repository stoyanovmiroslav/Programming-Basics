using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigLatter = Console.ReadLine();
            Console.WriteLine("{0}", bigLatter[0]);

            int asciiValue = (int)bigLatter[1];
            Console.WriteLine(asciiValue);
            
            char smalllatter1 = char.Parse(Console.ReadLine());
            char smalllatter2 = char.Parse(Console.ReadLine());
            char smalllatter3 = char.Parse(Console.ReadLine());

            var number = int.Parse(Console.ReadLine());
            var numberOfVarible = 0;

            for (int i = 65; i <=  asciiValue; i++)
            {
                for (int j = 97; j <= smalllatter1; j++)
                {
                    for (int k = 97; k <=smalllatter2; k++)
                    {
                        for (int l = 97; l <= smalllatter3; l++)
                        {
                            for (int m = 0; m <= number; m++)
                            {
                                numberOfVarible++;                               
                            }
                        }
                    }
                }
            }
            numberOfVarible = numberOfVarible - 1;
            Console.WriteLine(numberOfVarible);
        }
    }
}
