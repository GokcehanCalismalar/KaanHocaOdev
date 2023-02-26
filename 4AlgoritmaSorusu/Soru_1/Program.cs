using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_1
{
    internal class Program
    {

        static double GetBolunenToplam(double sayi)
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(GetBolunenToplam(1000));
            Console.ReadKey();

        }

    }
}
