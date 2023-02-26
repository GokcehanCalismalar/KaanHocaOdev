using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a+b+c nin toplam değeri nedir?");
            int s1 = Convert.ToInt32(Console.ReadLine());
            GetDegerleriGöster(s1);
            Console.ReadKey();
        }
        public static void GetDegerleriGöster(int s1)
        {
            for (int c = 0; c < int.MaxValue; c++)
            {
                for (int b = 0; b < c; b++)
                {
                    for (int a = 0; a < b; a++)
                    {
                        if (Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2))
                        {
                            if (a + b + c == s1)
                            {
                                Console.WriteLine($"a değeri:{a} - b değeri:{b} - c değeri: {c} - Toplamı {s1}");
                            }
                        }
                    }
                }
            }
        }
    }
}
