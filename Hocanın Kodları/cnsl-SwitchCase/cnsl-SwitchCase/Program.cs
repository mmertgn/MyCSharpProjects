using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen mevsime ait ayları listeleyen Console uygulamasını yazınız.
            Console.Write("Bir mevsim giriniz : ");
            //string Mevsim = Console.ReadLine().ToLower();
            //if (Mevsim == "ilkbahar")
            //    Console.Write("Aylar : Mart, Nisan, Mayıs");
            //else if (Mevsim == "yaz")
            //    Console.Write("Aylar : Haziran, Temmuz, Ağustos");
            //else if (Mevsim == "sonbahar")
            //    Console.Write("Aylar : Eylül, Ekim, Kasım");
            //else if (Mevsim == "kış")
            //    Console.Write("Aylar : Aralık, Ocak, Şubat");
            //else { Console.Write("Yanlış mevsim girişi!"); }

            string Mevsim = Console.ReadLine();
            switch (Mevsim.ToLower())
            {
                case "ilkbahar":
                    Console.Write("Aylar : Mart, Nisan, Mayıs");
                    break;
                case "yaz":
                    Console.Write("Aylar : Haziran, Temmuz, Ağustos");
                    break;
                case "sonbahar":
                    Console.Write("Aylar : Eylül, Ekim, Kasım");
                    break;
                case "kış":
                    Console.Write("Aylar : Aralık, Ocak, Şubat");
                    break;
                default:
                    Console.Write("Yanlış mevsim girişi!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
