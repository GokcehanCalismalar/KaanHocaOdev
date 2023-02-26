using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Çember_OPP;

namespace OOP_ALL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Çember Oluşturma
            Cember c1 = new Cember("c1", 7, 4, 3);
            c1.Yaz();
            c1.GetAlan();
            c1.GetCevre();
            c1.TegetYap('X');
            Console.WriteLine($"X kordinatı:{c1.Merkezx} Y kordinatı:{c1.Merkezy}");
            c1.TegetYap('Y');
            Console.WriteLine($"Y'ye göre teget olması:X kordinatı:{c1.Merkezx} Y kordinatı:{c1.Merkezy}");
            Ayrac();
            Cember c2 = new Cember("c2", 6, 4, 1);
            c2.Yaz();
            c2.GetAlan();
            c2.GetCevre();
            c2.TegetYap('X');
            Console.WriteLine($"X kordinatı:{c2.Merkezx} Y kordinatı:{c2.Merkezy}");
            c2.TegetYap('Y');
            Console.WriteLine($"X kordinatı:{c2.Merkezx} Y kordinatı:{c2.Merkezy}");
            c2.TegetYap('X', 'Y');
            Console.WriteLine($"X kordinatı:{c2.Merkezx} Y kordinatı:{c2.Merkezy}");

            Console.WriteLine($"{c2.Ad} {c1.Ad}'ın içerisinde mi : " + c1.icindeMi(c2));
            Console.WriteLine("Büyük Çember: " + c1.BuyukOlan(c2).Ad); 
            #endregion


            Console.ReadLine();
        }

        private static void Ayrac()
        {
            Console.WriteLine(new String ('*',10));
        }
    }
}
