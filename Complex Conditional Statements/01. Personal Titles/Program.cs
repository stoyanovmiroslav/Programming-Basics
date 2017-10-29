using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            string personalTitle;

            if (age < 16)
            {
                if (gender == "m")
                {
                    personalTitle = "Master";
                }
                else
                {
                    personalTitle = "Miss";
                }

            }
            else
            {
                if (gender == "f")
                {
                    personalTitle = "Ms.";
                }
                else
                {
                    personalTitle = "Mr.";
                }
            }
            Console.WriteLine(personalTitle);
        }
    }
}
