using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_DortIslem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.sayıyı giriniz : ");
            int Sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2.sayıyı giriniz : ");
            int Sayi2 = int.Parse(Console.ReadLine());
            basla:
            Console.WriteLine();
            Console.WriteLine("İşlem Menüsü");
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkarma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");
            Console.WriteLine("0-Çıkış");
            Console.Write("Seçiminiz : ");
            string Secim = Console.ReadLine();
            if (Secim == "1")
                Console.WriteLine("{0} + {1} = {2}", Sayi1, Sayi2, Sayi1 + Sayi2);
            else if (Secim == "2")
                Console.WriteLine("{0} - {1} = {2}", Sayi1, Sayi2, Sayi1 - Sayi2);
            else if (Secim == "3")
                Console.WriteLine("{0} * {1} = {2}", Sayi1, Sayi2, Sayi1 * Sayi2);
            else if (Secim == "4")
                if (Sayi2 != 0)
                {
                    Console.WriteLine("{0} / {1} = {2}", Sayi1, Sayi2, Sayi1 / Sayi2);
                }
                else
                {
                    Console.WriteLine("Sıfıra (0) bölme yapılamaz!");
                }
            else if (Secim == "0")
                return;
            else
            {
                Console.WriteLine("0-4 arası seçim yapmalısınız!");
                Console.ReadKey();
            }
            goto basla;
        }
    }
}
