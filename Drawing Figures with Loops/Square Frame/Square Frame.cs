﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string FirstLastRow = "+"; 
            for (int i = 0; i < n-2 ; i++)
            {
                FirstLastRow = FirstLastRow + " -";
            }
            FirstLastRow = FirstLastRow + " +";
            Console.WriteLine(FirstLastRow);

            for (int i = 0; i < n-2; i++)
            {
                Console.Write("|");

                for (int j = 0; j < n-2 ; j++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }


            Console.WriteLine(FirstLastRow);


        }
    }
}
