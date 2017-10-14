using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_DoWhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DO-WHILE DÖNGÜSÜ");
            Console.WriteLine("Şimdiye kadar gördüğümüz döngülerin belirli bir koşul sağlanıyorsa çalıştıklarını gördük.");
            Console.WriteLine("Do-While döngüsü ise; koşul sağlansa da sağlanmasa da en az 1 defa çalıştırılır.");
            Console.WriteLine("Kullanımı:");
            Console.WriteLine("do");
            Console.WriteLine("{ Kod bloğu... Burada yine değişken artılır ya da azaltılır... }");
            Console.WriteLine("while (Şart);");
            Console.WriteLine("Örnek:");
            int sayac = 0;
            int toplam = 0;
            do
            {
                sayac++;
                toplam += sayac;
            } while (sayac < 100);
            Console.WriteLine("1-100 arasındaki sayıların toplamı= " + toplam + " Sayacın aldığı son değer= " + sayac);
            Console.WriteLine("Bu örnekte 1-100 arasındaki sayıların toplamı ve sayacın son çalıştığı anda aldığı değer gösterilmiştir.");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Şimdi ise kullanıcıdan şifre girmesini isteyelim. Girilen şifre 1905'e eşitse giriş başarılı ve 3 defa deneyip şifre doğru bulunamamışsa giriş başarısız yazdıran programı yazalım.");
            string gsifre = "";
            int hak = 0;
            do
            {
                Console.Write("Şifre giriniz: ");
                gsifre = Console.ReadLine();
                hak++;
            } while (hak < 3 && gsifre != "1905");
            if (gsifre == "1905")
            {
                Console.WriteLine("Giriş başarılı !");
            }
            else if (hak == 3)
            {
                Console.WriteLine("Hakkınız doldu ! Giriş başarısız !");
            }
            Console.ReadKey();
        }
    }
}
