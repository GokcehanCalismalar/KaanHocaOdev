using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Bu program iki sayı arasındaki sayıların toplamlarının karesi ve karelerinin toplam farkını göstermektedir.");
            Console.WriteLine("Lütfen ilk sayıyı giriniz");
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen ilk sayıyı giriniz");
            int s2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Toplamlarının karesi :{GetToplamKare(s1,s2)}',karelerinin toplamı:{GetKareToplam(s1,s2)}, farkı : {GetToplamKare(s1, s2)- GetKareToplam(s1, s2)}");
            Console.ReadKey();
        }
        public static double GetKareToplam(int s1,int s2)
        {
            double kareToplam = 0;
            for (int i = s1; i <= s2; i++)
            {
                kareToplam += Math.Pow(i, 2);
            }
            return kareToplam;
        }
        public static double GetToplamKare(int s1, int s2)
        {
            double toplamKare = 0, toplam = 0;
            for (int i = s1; i <= s2; i++)
            {
                toplam += i;
            }
            toplamKare = Math.Pow(toplam, 2);
            return toplamKare;
        }
    }
}
