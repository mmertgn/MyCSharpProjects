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
            //while (i < 5)    //Şart sağlandığı sürece işlemler tekrar edilir.
            //{
            //    Console.WriteLine("Merhaba");
            //    i++;
            //}
            //int i = 0;
            //for (; i < 5 ;)
            //{
            //    Console.WriteLine("Merhaba");
            //    i++;
            //}
            //Başlangıç, Bitiş ve Artış değerleri klavyeden girilen ve başlangıç ile bitiş arasındaki sayıları ekranda gösteren döngüyü hem while hem for ile oluşturunuz.
            Console.Write("Başlangıç değeri : ");
            int bas = int.Parse(Console.ReadLine());
            Console.Write("Bitiş değeri : ");
            int bit = int.Parse(Console.ReadLine());
            Console.Write("Artış değeri : ");
            int artis = int.Parse(Console.ReadLine());
            //for (int i = bas; i <= bit; i+=artis)
            //{
            //    Console.WriteLine(i);
            //}
            while (bas <= bit)
            {
                Console.WriteLine(bas);
                bas = bas + artis;
            }
            Console.ReadKey();
        }
    }
}
