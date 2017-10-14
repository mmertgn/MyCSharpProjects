using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_KdvSecimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Malın Fiyatı?
            //Kdv Menüsü
            //1-Gıda Ürünleri (%1)
            //2-Sağlık Ürünleri (%8)
            //3-Diğer Ürünler (%18)
            //Seçiminiz : x
            Console.Write("Malın Fiyatı : ");
            float MF = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("KDV Menüsü");
            Console.WriteLine("1- Gıda Ürünleri   (%1)");
            Console.WriteLine("2- Sağlık Ürünleri (%8)");
            Console.WriteLine("3- Diğer Ürünler (%18)");
            Console.Write("Seçiminiz : ");
            string Secim = Console.ReadLine();
            float Kdv = 0;
            if(Secim == "1")
            {
                Kdv = MF * 1 / 100;
            }
            else if (Secim == "2")
            {
                Kdv = MF * 8 / 100;
            }
            else if (Secim == "3")
            {
                Kdv = MF * 18 / 100;
            }
            else
            {
                Console.WriteLine("1-3 arası seçim yapmalısınız!");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Fiyat : {0}, Kdv Tutarı : {1}, Toplam Tutar : {2}", MF, Kdv, MF + Kdv);

            Console.ReadKey();
        }
    }
}
