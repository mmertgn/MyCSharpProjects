using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_YasOrtalamasiByCinsiyet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen cinsiyet ve yaş bilgilerine göre, kızların sayısı ve yaş ortalaması ile erkeklerin sayısı ve yaş ortalaması
            //gösteren uygulamayı yazınız...
            int erkeksayisi = 0, kizsayisi = 0;
            int ETopYas = 0, KTopYas = 0;
            string devam;

            do
            {
                Console.Write("Cinsiyetiniz(Erkek/Kız) : ");
                string cinsiyet = Console.ReadLine().ToLower();
                Console.Write("Yaşınız : ");
                int yas = int.Parse(Console.ReadLine());

                if (cinsiyet == "erkek")
                {
                    erkeksayisi++;
                    ETopYas = ETopYas + yas;
                }
                else if (cinsiyet == "kız")
                {
                    kizsayisi++;
                    KTopYas = KTopYas + yas;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız!!!");
                }
                Console.Write("Devam mı?(E/H) : ");
                devam = Console.ReadLine().ToLower();
            } while (devam == "e");

            if (erkeksayisi > 0)
                Console.WriteLine("Erkek sayisi : {0} , Erkek Yas Ortalaması : {1} ", erkeksayisi, ETopYas / erkeksayisi);
            else
                Console.WriteLine("Erkek öğrenci girişi yapılmamıştır.");
            if (kizsayisi > 0)
                Console.WriteLine("Kız sayisi : {0} , Kız Yas Ortalaması : {1} ", kizsayisi, KTopYas / kizsayisi);
            else
                Console.WriteLine("Kız öğrenci girişi yapılmamıştır.");

            Console.ReadKey();
        }
    }
}
