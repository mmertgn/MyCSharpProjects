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
            Console.WriteLine("WHILE DÖNGÜSÜ");
            Console.WriteLine("While döngüsü, değeri bilinen bir değişken kullanılarak oluşturulan bir döngüdür.");
            Console.WriteLine("While döngüsünde belirlenen komut bloğunu, koşul sağlandığı sürece tekrarlar.");
            Console.WriteLine("int i = 1");
            Console.WriteLine("while (i <= 10)");
            Console.WriteLine("{ Çalıştırılacak kod bloğu... i++/--; (Kodlar çalıştığı sürece i değeri ya artırılır ya da azaltılır.) }");
            Console.WriteLine("Örnek (Klavyeden girilen sayıdan 1'e kadar olan sayıları altalta yazdıran program):");
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            while (sayi >= 1)
            {
                Console.WriteLine(sayi);
                sayi--;
            }
            Console.ReadKey();
            Console.WriteLine("Bu örnekte klavyeden alınan bir int değişkeninden 1'e kadar olan sayılar ekrana yazdırılmıştır.");
            Console.WriteLine();
            Console.WriteLine("Şimdi 0-100 arasındaki tek sayıların toplamını bulan programı while döngüsü ile oluşturalım.");
            int toplam = 0;
            int say = 0;
            while (say <= 100)
            {
                if (say % 2 == 1)
                {
                    toplam += say;
                }
                say++;
            }
            Console.WriteLine("0-100 arasındaki tek sayıların toplamı= " + toplam);
            Console.ReadKey();
        }
    }
}
