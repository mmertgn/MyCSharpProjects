using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_Toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.sayıyı giriniz : ");
            string Sayi1 = Console.ReadLine();
            Console.Write("2.sayıyı giriniz : ");
            string Sayi2 = Console.ReadLine();
            //Console.Write(Sayi1 + Sayi2);
            int S1, S2;
            S1 = int.Parse(Sayi1);
            S2 = int.Parse(Sayi2);
            //Console.Write("Toplam = " + (S1 + S2));
            int T = S1 + S2;
            //Console.Write("Toplam = " + T);
            Console.WriteLine("1.Sayı : {0}, 2.Sayı : {1}, Toplam = {2}", S1, S2, S1 + S2);

            Console.ReadKey();
        }
    }
}
