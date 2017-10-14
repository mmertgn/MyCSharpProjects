using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_dortislem
{
    class Program
    {
        static void Main(string[] args)
        {
            basla:
            Console.Write("1. sayıyı giriniz. ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2.sayıyı giriniz. ");
            int sayi2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("işlem menüsü");
            Console.WriteLine("1-toplamma");
            Console.WriteLine("2-çıkarma");
            Console.WriteLine("3-çarpma");
            Console.WriteLine("4-bölme");
            Console.Write("seçiniz : ");
            string secim = Console.ReadLine();
            if (secim == "1")
                Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, sayi1 + sayi2);
            else if (secim == "2")
                Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, sayi1 - sayi2);
            else if (secim == "3")
                Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, sayi1 * sayi2);
            else if (secim == "4")
                if (sayi1 != 0)
                {
                    Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, sayi1 / sayi2);
                }
                else
                {
                    Console.WriteLine("Sıfıra bölme yapılamaz!");
                }
            else
                Console.WriteLine("1-4 arası seçim yapmalısınız!");
           
            Console.ReadKey();

            goto basla;





        }
    }
}
