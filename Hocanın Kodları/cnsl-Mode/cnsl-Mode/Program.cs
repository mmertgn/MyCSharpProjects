using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_Mode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan sayıya kadar olan sayıların toplamının, bu sayılardan 3 ve 3 ün katları olanların toplamına bölümünü gösteren uygulamayı yazınız.
            Console.Write("Bir sayı girin : ");
            int Sayi = int.Parse(Console.ReadLine());
            int Genel = 0, UcToplam = 0;
            for (int i = 1; i <= Sayi; i++)
            {
                Genel = Genel + i;
                if (i % 3 == 0)
                    UcToplam = UcToplam + i;
            }
            Console.WriteLine("Tüm Sayıların Toplamı {0}, Üçe Bölünenlerin Toplamı {1}, Birbirine Bölümü {2}", Genel, UcToplam, Genel / UcToplam);
            Console.ReadKey();
        }
    }
}
