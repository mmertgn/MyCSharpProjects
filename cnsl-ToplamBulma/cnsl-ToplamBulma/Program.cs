using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_ToplamBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            //1-10 arası sayıları ve bu sayıların toplamını gösteren uygulamayı yazınız
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                toplam = toplam + i;
            }

            Console.WriteLine("Toplam = {0}", toplam);

            Console.ReadKey();
        }
    }
}
