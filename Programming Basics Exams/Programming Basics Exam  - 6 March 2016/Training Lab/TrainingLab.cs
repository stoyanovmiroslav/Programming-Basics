using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Lab
{
    class TrainingLab
    {
        static void Main(string[] args)
        {
            var w = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var resulth = (int)(h * 100 - 100)/70;
            var resultw = (int)(w * 100) / 120;

            var result = resulth * resultw - 3;
            Console.WriteLine(result);


        }
    }
}
