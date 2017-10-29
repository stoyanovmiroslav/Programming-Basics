using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            double price = 0.0d;
            if (product == "coffee")
                if (town == "sofia") price = 0.5;
                else if (town == "varna") price = 0.45;
                else if (town == "plovdiv") price = 0.40;
            if (product == "water")
                if (town == "sofia") price = 0.8;
                else if (town == "varna") price = 0.7;
                else if (town == "plovdiv") price = 0.7;
            if (product == "beer")
                if (town == "sofia") price = 1.2;
                else if (town == "varna") price = 1.10;
                else if (town == "plovdiv") price = 1.15;
            if (product == "sweets")
                if (town == "sofia") price = 1.45;
                else if (town == "varna") price = 1.35;
                else if (town == "plovdiv") price = 1.30;
            if (product == "peanuts")
                if (town == "sofia") price = 1.6;
                else if (town == "varna") price = 1.55;
                else if (town == "plovdiv") price = 1.50;

            Console.WriteLine(price * quantity);
        }
    }
}
