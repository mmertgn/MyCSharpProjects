using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_kdvsecimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Malın Fiyatı: ");
            float fiyat = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("KDV Menüsü");
            Console.WriteLine("1-Gıda Ürünleri (%1)");
            Console.WriteLine("2-Sağlık Ürünleri (%8)");
            Console.WriteLine("3-Diğer Ürünler (%18)");
            Console.Write("Seçiminiz : ");

            string secim = Console.ReadLine();
            if (secim == "1")
            {
                Console.Write("Malın fiyatı :{0} TL, Kdv : {1} TL, Kdvli Fiyat : {2} TL", fiyat, fiyat * 1 / 100, fiyat+(fiyat*1/100));
            }
            else if (secim == "2")
            {
                Console.Write("Malın fiyatı :{0} TL, Kdv : {1} TL, Kdvli Fiyat : {2} TL", fiyat, fiyat * 8 / 100, fiyat + (fiyat *8/100));
            }
            else if (secim == "3")
            {
                Console.Write("Malın fiyatı :{0} TL, Kdv : {1} TL, Kdvli Fiyat : {2} TL \n", fiyat, fiyat * 18 / 100, fiyat + (fiyat *18/100));
            }
            else
            {
                Console.WriteLine("1-3 arası seçim yapmalısınız!");
            }

            Console.ReadKey();
        }
    }
}
