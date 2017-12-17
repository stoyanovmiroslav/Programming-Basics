using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svetovenRekord
{
    class Program
    {
        static void Main(string[] args)
        {
            var rekordSek = double.Parse(Console.ReadLine());
            var raztoqnieMeter = double.Parse(Console.ReadLine());
            var sekOneMeter = double.Parse(Console.ReadLine());

            var sek = raztoqnieMeter * sekOneMeter ;
            var dopraz = (int)raztoqnieMeter / 15 ;
            var dopraz1 = dopraz * (double)12.5;
            

            sek = dopraz1 + sek;

            if (sek >= rekordSek)
            {
                sek = sek - rekordSek;
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", sek);
            }else
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", sek);
            }
        }
    }
}
