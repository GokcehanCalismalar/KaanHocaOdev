using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1'den kaça kadar sayıların bölünebildiği değeri öğrenmek istiyorsunuz?");
            int s1 = Convert.ToInt32(Console.ReadLine());
            GetSmallestNumber(s1);

            Console.ReadKey();

        }

        public static void GetSmallestNumber(int son)
        {
            int k = int.MaxValue, value = int.MaxValue;
            for (int i = 1; i < k; i++)
            {

                do
                {
                    value++;
                    if (value == son)
                    {
                        Console.WriteLine(i);

                    }

                } while (i % value == 0);
                value = 1;

            }
        }
    }
}
