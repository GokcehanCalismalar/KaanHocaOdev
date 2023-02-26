using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dikdortgen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dortgen dortgen = new Dortgen("Dörtgen1", 5, 7, 10, 2);
            dortgen.Yaz();
            dortgen.GetBoy();
            dortgen.GetEn();   
            dortgen.GetAlan();
            dortgen.GetCevre();
            dortgen.KareYap();
            

            Dortgen dortgen1 = new Dortgen("Dortgen2", 5, 10, 17, 4);
            dortgen1.Yaz();
            dortgen1.GetBoy();
            dortgen1.GetEn();
            dortgen1.GetAlan();
            dortgen1.GetCevre();
            dortgen1.KareYap();
            dortgen.BuyukOlan(dortgen1);

            Console.Read();
        }
    }
}
