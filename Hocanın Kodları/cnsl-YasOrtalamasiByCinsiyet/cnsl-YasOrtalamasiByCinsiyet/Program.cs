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
            //Klavyeden girilen Cinsiyet ve Yaş bilgilerine göre Kızların Sayısı ve Yaş Ortalaması ile Erkeklerin Sayısı ve Yaş Ortalamasını gösteren uygulamayı yazınız.
            int KS = 0, ES = 0, KTop = 0, ETop = 0;
            string Devam = "";
            do
            {
                Console.Write("Cinsiyet (E/K) : ");
                string Cns = Console.ReadLine().ToUpper();
                Console.Write("Yaş Giriniz : ");
                int Yas = int.Parse(Console.ReadLine());
                if(Cns == "K")
                {
                    KS++;   //Kızların sayısı 1 artar.
                    KTop += Yas; //Kızların yaşlarına eklenir.
                }
                else if(Cns == "E")
                {
                    ES++;   //Erkeklerin sayısı 1 artar.
                    ETop += Yas;    //Erkeklerin yaşlarına eklenir.
                }
                Console.Write("Devam mı (E/H)?");
                Devam = Console.ReadLine().ToUpper();
            } while (Devam == "E");
            Console.WriteLine("Kızların Sayısı {0}, Yaş Ortalaması {1} \n Erkeklerin Sayısı {2}, Yaş Ortalaması {3}", KS, KTop / KS, ES, ETop / ES);
            Console.ReadKey();
        }
    }
}
