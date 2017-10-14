using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_Mod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan sayıya kadar olan sayıların toplamının, bu sayılardan 3 ve 3 ün katları olanların toplamına bölümünü gösteren uygulamayı yazınız
            float toplam = 0;
            float UcKati = 0;
            Console.Write("Sayi giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                toplam = toplam + i;
                if (i % 3 == 0)
                {
                    UcKati = UcKati + i;
                }
            }

            float Sonuc = toplam / UcKati;
            Console.WriteLine("Sonuc :" + Sonuc);

            Console.ReadKey();
        }
    }
}
