using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = int.MaxValue;
            var totalsum = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                var firstnumber = int.Parse(Console.ReadLine());
                var secondnumber = int.Parse(Console.ReadLine());
                if (sum != firstnumber + secondnumber && sum != int.MaxValue)
                {
                    var sum2 = firstnumber + secondnumber;
                    var totalsum2 = sum - sum2;
                    totalsum = Math.Max(Math.Abs(totalsum2), totalsum);
                }
                sum = firstnumber + secondnumber;
            }
            if (totalsum != int.MinValue)
            {
                Console.WriteLine("No, maxdiff={0}", totalsum);
            }
            else
            {
                Console.WriteLine("Yes, value ={0}", sum);
            }
        }
    }
}
