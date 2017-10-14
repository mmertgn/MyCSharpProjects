using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_doWhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Şifre olarak 9999 girilinceye kadar şifre istemeye devam eden uygulamayı yazınız. 
            //Şifre girişini 3 hakla sınırlandıralım.
            string Sifre;
            int s = 0;
            do  //Döngü içindeki işlemler en az 1 defa çalıştırılır.
            {
                Console.Write("Şifreyi giriniz : ");
                Sifre = Console.ReadLine();
                s++;
            } while (Sifre != "9999" && s < 3);
            if (Sifre == "9999")
                Console.WriteLine("Hoşgeldiniz...");
            else
                Console.WriteLine("Hakkınız doldu!");
            Console.ReadKey();
        }
    }
}
