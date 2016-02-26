using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D8T1
{
    class Program
    {
        static void Main(string[] args)
        {

            double Summa = 0;
            double Keskiarvo;
            int NoppaTulos;
            int Kertaa=0;
            int Kertaa1;
            int laskuri=1;

            Console.Write("\n\n  Montako kertaa heitetaan: ");
            Kertaa = int.Parse(Console.ReadLine());
            Console.Write("\n");

            Kertaa1 = Kertaa;

            while (Kertaa1 > 0)
            {
                NoppaTulos = Noppa.Nopanheitto();
                Console.WriteLine("  ({0}) Tulos {1} ", laskuri, NoppaTulos);
                Summa += NoppaTulos;
                Kertaa1--;
                laskuri++;
            }

            Keskiarvo = Summa / Kertaa;

            Console.WriteLine("\n\n  Keskiarvo: {0}",Keskiarvo);
            Console.WriteLine("\n\n");

        }
    }
}
