using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci sayı giriniz:");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci sayı giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.Write("Hangi İşlemi yapmak istiyorsunuz?");
            string islem = Console.ReadLine();
            switch (islem.ToLower())
            {
                case "toplama":
                    Console.WriteLine("Toplam:" + (sayi1 + sayi2)
                    );
                    break;

                case "çıkarma":
                    Console.WriteLine("Toplam:" + (sayi1 - sayi2)
                    );
                    break;
                case "çarpma":
                    Console.WriteLine("Toplam:" + (sayi1 * sayi2)
                    );
                    break;
            }
            //if (sayi1 < sayi2)
            //{
            //    Console.Write("1.Sayı 2.Sayıdan küçüktür.");
            //}
            //else if (sayi1 == sayi2)
            //{
            //    Console.Write("1.Sayı 2.Sayıya eşittir.");
            //}
            //else
            //{
            //    Console.Write("2.Sayı 1.Sayıdan küçüktür.");
            //}
            Console.ReadKey();

        }
    }
}
