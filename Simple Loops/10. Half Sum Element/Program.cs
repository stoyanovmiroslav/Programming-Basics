using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int num = 0;
            int HalfSumElement = 0;
            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (max < num)
                    max = num;
                HalfSumElement += num;
            }
            HalfSumElement -= max;
            int diff = Math.Abs(HalfSumElement - max);
            if (diff == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum =" + max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff =" + diff);
            }
        }
    }
}
