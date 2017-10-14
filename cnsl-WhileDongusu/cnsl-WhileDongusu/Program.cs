using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_WhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (i < 5) //şart sağlandığı sürece döngü tekrar edilir.
            //{
            //    Console.WriteLine("Merhaba!");
            //    i++;
            //}

            //int i = 0;
            //for (; i < 5;)
            //{
            //    Console.WriteLine("Merhaba!");
            //    i++;
            //}

            //Başlangıç, bitiş ve artış değerleri klavyeden girilen ve başlangıç ile bitiş arasındaki sayıları ekranda gösteren 
            //döngüyü hem while hemde for ile oluşturunuz.

            Console.Write("Başlangıç Değerini Giriniz: ");
            int baslangic = int.Parse(Console.ReadLine());
            Console.Write("Artış Değerini Giriniz: ");
            int artis = int.Parse(Console.ReadLine());
            Console.Write("Bitis Değerini Giriniz: ");
            int bitis = int.Parse(Console.ReadLine());

            for (int i = baslangic; i <= bitis; i=i+artis)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            int j = baslangic;
            while (j <= bitis)
            {
                Console.WriteLine(j);
                j=j+artis;
            }

            Console.ReadKey();
        }
    }
}
