using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_4
{
    internal class Program
    {
        static int GetPalindrom(int sayi)
        {
            int birlerbas = 0, onlarbas = 0, yüzlerbas = 0, binlerbas = 0, onbinlerbas = 0, yüzbinlerbas = 0, sonuc = 0, enBuyuk = 0;

            if (sayi == 3)
            {
                for (int i = 100; i < 1000; i++)
                {
                    for (int j = 100; j < 1000; j++)
                    {
                        sonuc = i * j;
                        birlerbas = sonuc % 10;
                        onlarbas = (sonuc % 100) / 10;
                        yüzlerbas = (sonuc % 1000) / 100;
                        binlerbas = (sonuc % 10000) / 1000;
                        onbinlerbas = (sonuc % 100000) / 10000;
                        yüzbinlerbas = (sonuc % 1000000) / 100000;
                        if (birlerbas == yüzbinlerbas && onlarbas == onbinlerbas && yüzlerbas == binlerbas)
                        {
                            enBuyuk = Math.Max(enBuyuk, sonuc);
                        }
                    }
                }
            }
            return enBuyuk;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç basamaklı iki sayının çarpımı ile olan en büyük palandromic sayıyı öğrenmek istiyorsunuz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = GetPalindrom(sayi);
            Console.WriteLine(sonuc);
            Console.ReadKey();
        }
    }
}
