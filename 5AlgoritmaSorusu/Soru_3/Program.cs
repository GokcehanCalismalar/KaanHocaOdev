using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kacıncı asal sayıyı bulmak istiyorsunuz");
            int aralik = Convert.ToInt32(Console.ReadLine());
            GetAsalSayi(aralik);
            Console.ReadKey();
        }
        public static void GetAsalSayi(int aralik)
        {
            int count = 1, sayi = int.MaxValue, sayac;
            for (int i = 2; i < sayi; i++)
            {
                sayac = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sayac++;
                    }
                }
                if (sayac == 0)
                {
                    if (count == aralik)
                    {
                        Console.WriteLine($"{aralik}.asal sayı => {i}");
                    }
                    count++;
                }

            }
        }
    }
}
