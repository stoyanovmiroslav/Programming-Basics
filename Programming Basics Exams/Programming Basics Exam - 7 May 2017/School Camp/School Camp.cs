using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine().ToLower();
            var gender = Console.ReadLine().ToLower();
            var numberStudents = int.Parse(Console.ReadLine());
            var numberNights = int.Parse(Console.ReadLine());
            var sport = "";
            var hotelPrice = 0.00;
            var percent = 0.00;
            if (season == "summer")
            {
                if (gender == "mixed") { hotelPrice = 20; sport = "Swimming"; }
            else if (gender == "girls") { hotelPrice = 15; sport = "Volleyball"; }
            else { hotelPrice = 15; sport = "Football"; }

            }
            else if (season == "spring")
            {
                if (gender == "mixed") { hotelPrice = 9.50; sport = "Cycling"; }
                else if (gender == "girls") { hotelPrice = 7.20; sport = "Athletics"; }
                else { hotelPrice = 7.20;  sport = "Tennis"; }
            }
            else if (season == "winter")
            {
                if (gender == "mixed") { hotelPrice = 10; sport = "Ski"; }
                else if (gender == "girls") { hotelPrice = 9.60; sport = "Gymnastics"; }
                else { hotelPrice = 9.60;  sport = "Judo"; }
            }

            if (numberStudents >= 50) percent = 0.50;
            else if (numberStudents >= 20 && numberStudents < 50) percent = 0.15;
            else if (numberStudents >= 10 && numberStudents < 20) percent = 0.05;

            var calculate = hotelPrice * numberStudents * numberNights;
            var calculate2 = calculate * percent;
            calculate = calculate - calculate2;

            Console.WriteLine("{0} {1:f2} lv.", sport, calculate);
            
        
        }
    }
}
