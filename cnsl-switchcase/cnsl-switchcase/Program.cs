using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden Bir mevsim girilsin girilen mevsime göre o mevsime ait ayları listeleyen console uygulamasını geliştiriniz
            Console.Write("Mevsim Giriniz: ");
            string mevsim = Console.ReadLine().ToLower();
            /*if(mevsim == "kış")
            {
                Console.Write("Girilen mevsime ait aylar; Aralık,Ocak,Şubat");
            }
            else if(mevsim == "sonbahar")
            {
                Console.Write("Girilen mevsime ait aylar; Eylül,Ekim,Kasım");
            }
            else if (mevsim == "ilkbahar")
            {
                Console.Write("Girilen mevsime ait aylar; Mart,Nisan,Mayıs");
            }
            else if (mevsim == "yaz")
            {
                Console.Write("Girilen mevsime ait aylar; Haziran,Temmuz,Ağustos");
            }
            else
            {
                Console.Write("Yanlış mevsim girdiniz!");
            }*/
            switch (mevsim)
            {
                case "yaz":
                    Console.Write("Girilen mevsime ait aylar; Haziran,Temmuz,Ağustos");
                    break;
                case "kış":
                    Console.Write("Girilen mevsime ait aylar; Aralık,Ocak,Şubat");
                    break;
                case "sonbahar":
                    Console.Write("Girilen mevsime ait aylar; Eylül,Ekim,Kasım");
                    break;
                case "ilkbahar":
                    Console.Write("Girilen mevsime ait aylar; Mart,Nisan,Mayıs");
                    break;
                default:
                    Console.Write("Yanlış mevsim girdiniz!");
                    break;
            }
               


            Console.ReadKey();
        }
    }
}
