using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_BOMOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            //BOM Oyunu : 1-100 arasındaki sayıları listelerken 5 ve 5 in katlarında sayı yerine BOM gösteren uygulamayı yazınız.

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //        Console.WriteLine("BOM");
            //    else
            //        Console.WriteLine(i);
            //}
            //BOM Oyunu : 1-100 arasındaki sayıları listelerken kullanıcının seçtiği sayı ve bu sayının katlarında sayı yerine BOM gösteren uygulamayı yazınız.
            //Console.Write("Bom Sayısı : ");
            //int sayi = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % sayi == 0)
            //        Console.WriteLine("BOM");
            //    else
            //        Console.WriteLine(i);
            //}
            //BOM oyunu bilgisayarla kullanıcı arasında oynansın. Bilgisayar başlasın, kullanıcı devam etsin. Sıra geldiğinde kullanıcıdan bilgi istensin, eğer sıradaki sayıyı yada BOM bilgisini doğru girerse oyun devam etsin, hatalı girdiğinde "Oyunu Kaybettiniz!" şeklinde oyun sona ersin. Hiç hata yapmazsa "Oyun Berabere" şeklinde oyunu bitiren uygulamayı yazınız.
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1) //Tek sayılarda bilgisayar oynuyor.
                {
                    if (i % 5 == 0)
                        Console.WriteLine("BOM");
                    else
                        Console.WriteLine(i);
                }
                else
                {
                    //Çift sayılarda kullanıcı oynuyor.
                    Console.Write("Sayı Girin : ");
                    string kullanici = Console.ReadLine().ToUpper();
                    if (i % 5 == 0 && kullanici != "BOM")
                    {
                        Console.WriteLine("Oyunu Kaybettiniz!");
                        break;
                    }
                    else if (i % 5 != 0 && kullanici != i.ToString())
                    {
                        Console.WriteLine("Oyunu Kaybettiniz!");
                        break;
                    }
                }
                if (i == 100) Console.WriteLine("Oyun Berabere...");
            }
            Console.ReadKey();
        }
    }
}
