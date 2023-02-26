using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_3
{
    internal class Program
    {
        static double GetBüyükAsalSayi(double sayi)
        {
            int enBuyuk = 2;
            for (int i = 2; i <= sayi; i++)
            {
                if (sayi % i == 0)
                {
                    enBuyuk = i;
                    sayi = sayi / i;
                    i = i - 1;

                }
            }
            return enBuyuk;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("En büyük asal çarpanını öğrenmek istediğiniz sayıyı giriniz");
            double sayi = Convert.ToDouble(Console.ReadLine());
            double sonuc = GetBüyükAsalSayi(sayi);
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
