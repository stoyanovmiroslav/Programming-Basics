using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            Console.WriteLine(FormString("$ ", i));
        }
        public static string FormString(string stringParam , int number)
        {
            StringBuilder stringBuild = new StringBuilder();
            for (int i = 1; i <= number; i++)
            {
                stringBuild.Append(stringParam);
            }
            return stringBuild.ToString();
        }
    }
}
