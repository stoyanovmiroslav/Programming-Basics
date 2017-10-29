using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = decimal.Parse(Console.ReadLine());
            var curin = Console.ReadLine();
            var curout = Console.ReadLine();

            if (curin == "BGN")
            {
                if (curout == "EUR")
                {
                    var bgeur = amount / 1.95583m;
                    Console.WriteLine(Math.Round(bgeur, 2));
                }
                if (curout == "GBP")
                {
                    var bggbr = amount / 2.53405m;
                    Console.WriteLine(Math.Round(bggbr, 2));

                }
                if (curout == "USD")
                {
                    var bgus = amount / 1.79549m;
                    Console.WriteLine(Math.Round(bgus, 2));
                }
            }
            if (curin == "EUR")
            {
                if (curout == "BGN")
                {
                    var bgeur = amount * 1.95583m;
                    Console.WriteLine(Math.Round(bgeur, 2));
                }
                if (curout == "GBP")
                {
                    var bggbr = amount / 1.29563m;
                    Console.WriteLine(Math.Round(bggbr, 2));

                }
                if (curout == "USD")
                {
                    var bgus = amount * 1.08930m;
                    Console.WriteLine(Math.Round(bgus, 2));
                }
            }
            if (curin == "GBP")
            {
                if (curout == "EUR")
                {
                    var bgeur = amount * 1.29563m;
                    Console.WriteLine(Math.Round(bgeur, 2));
                }
                if (curout == "BGN")
                {
                    var bggbr = amount * 2.53405m;
                    Console.WriteLine(Math.Round(bggbr, 2));

                }
                if (curout == "USD")
                {
                    var bgus = amount * 1.41134m;
                    Console.WriteLine(Math.Round(bgus, 2));
                }
            }
            if (curin == "USD")
            {
                if (curout == "EUR")
                {
                    var bgeur = amount / 1.08930m;
                    Console.WriteLine(Math.Round(bgeur, 2));
                }
                if (curout == "GBP")
                {
                    var bggbr = amount / 1.41134m;
                    Console.WriteLine(Math.Round(bggbr, 2));

                }
                if (curout == "BGN")
                {
                    var bgus = amount * 1.79549m;
                    Console.WriteLine(Math.Round(bgus, 2));
                }
            }
        }
    }
}
