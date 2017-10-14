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
            int sifre;
            int hak = 0;
            //Şifre olarak 9999 girilinceye kadar şifre istemeye devam eden uygulamayı yazınız, şifre girişini 3 hakla sınırlandır
            do //Döngü içindeki işlemler en az 1 defa çalıştırılır.
            {
                Console.Write("Şifreyi giriniz:");
                sifre = int.Parse(Console.ReadLine());
                hak++;
            } while (sifre != 9999 && hak!=3);

            if (sifre != 9999)
            {
                Console.WriteLine("Çok fazla hatalı giriş yaptınız...");
            }
            else
            {
                Console.WriteLine("Hoşgeldiniz...");
            }

            
            Console.ReadKey();
        }
    }
}
