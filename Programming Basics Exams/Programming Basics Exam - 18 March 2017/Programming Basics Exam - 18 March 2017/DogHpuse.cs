using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Basics_Exam___18_March_2017
{
    class DogHpuse
    {
        static void Main(string[] args)
        {
            var sideSideLong = double.Parse(Console.ReadLine());
            var heightHouse = double.Parse(Console.ReadLine());

            var twoSides = sideSideLong * (sideSideLong / 2) * 2;
            
            var triangle1 = ((sideSideLong / 2) * (heightHouse - sideSideLong / 2)) / 2;
            var backSide = (sideSideLong / 2) * (sideSideLong / 2) + triangle1;


            var frondDoorSide = (sideSideLong / 5);
            var frondSide = frondDoorSide * frondDoorSide;
            var frontSideMinusDoor = backSide - frondSide;

            var obshtaPloshtSides = frontSideMinusDoor + backSide + twoSides;
        
            var greenPain = obshtaPloshtSides / 3;
            var roof = sideSideLong * (sideSideLong / 2) * 2;
            var redPain = roof / 5;

            Console.WriteLine("{0:f2}",greenPain);
           
            Console.WriteLine("{0:f2}", redPain);



               



        }
    }
}
