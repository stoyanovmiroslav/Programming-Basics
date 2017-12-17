using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blagotvoritelnaKampaniq
{
    class Program
    {
        
            static void Main(string[] args)
            {
            var days = int.Parse(Console.ReadLine());
            var sladkarite = int.Parse(Console.ReadLine());
            var torti = double.Parse(Console.ReadLine());
            var gofreti = double.Parse(Console.ReadLine());
            var palachinki = double.Parse(Console.ReadLine());

            torti *= 45;
            gofreti *= 5.80;
            palachinki *= 3.20;
            var sum = torti + gofreti + palachinki;
            sum *= sladkarite;
            sum *= days;
            sum = sum - (sum * 1 / 8);
            Console.WriteLine("{0:f2}", sum);

        }
        }
    }

    