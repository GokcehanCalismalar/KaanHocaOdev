using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_2
{
    internal class Program
    {
        static int GetCiftToplam(int deger)
        {
            int s1 = 0;
            int s2 = 1;
            int fibonocci = 0;
            int ciftToplam = 0;
            for (int i = 0; fibonocci < deger; i++)
            {
                fibonocci = s1 + s2;
                s1 = s2;
                s2 = fibonocci;
                if (fibonocci % 2 == 0)
                {
                    ciftToplam += fibonocci;
                }
            }
            return ciftToplam;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = GetCiftToplam(sayi);

            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
