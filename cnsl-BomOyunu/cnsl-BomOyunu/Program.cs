using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_BomOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-100 e kadar sayılarda 5 kime gelirse bom der, 2. olarak kullanıcıya da sordur
            //Bir bilgisayar bir kullanıcı oynuyor başlayan bilgisayar, kullanıcı girdiği sayıyı kontrol et bom u kontrol et, 
            //bilgisayar kaybedemez, 1-100 e kadar yap

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i%5==0)
            //    {
            //        Console.WriteLine("BOM");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            Console.Write("Oyun Kaça Kadar Oynansın:");
            int sonsayi = int.Parse(Console.ReadLine());
            Console.Write("Bom Sayısını Giriniz:");
            int bomsayisi = int.Parse(Console.ReadLine());
            int sayi = 1;
            while (sayi <= sonsayi)
            {
                if (sayi % bomsayisi == 0)
                    Console.WriteLine("Bilgisayar : BOM");
                else
                    Console.WriteLine("Bilgisayar : " + sayi);

                Console.Write("Kullanıcı : ");

                if ((sayi+1) % bomsayisi == 0)
                {
                    string giris = Console.ReadLine().ToLower();
                    if (giris != "bom")
                    {
                        Console.WriteLine("Kullanıcı Oyunu Kaybetti");
                        break;
                    }
                    else
                    {
                        sayi = sayi + 2;
                    }
                }
                else
                {
                    int sayigiris = int.Parse(Console.ReadLine());
                    if (sayigiris != sayi+1)
                    {
                        Console.WriteLine("Kullanıcı Oyunu Kaybetti");
                        break;
                    }
                    else
                    {
                        sayi += 2;
                    }
                }

                if (sonsayi+1 == sayi)
                {
                    Console.WriteLine("Oyun Berabere!!!");

                }

            }


            Console.ReadKey();

        }
    }
}
