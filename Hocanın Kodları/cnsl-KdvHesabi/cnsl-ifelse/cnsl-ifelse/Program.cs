using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.sayıyı giriniz : ");
            int Sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2.sayıyı giriniz : ");
            int Sayi2 = int.Parse(Console.ReadLine());

            if (Sayi1 > Sayi2)
            {
                Console.Write("1.sayı daha büyük.");
            }
            else if (Sayi1 < Sayi2)
            {
                Console.Write("2.sayı daha büyük.");
            }
            else
            {
                Console.Write("Sayılar eşit.");
            }

            //if (Sayi1 > Sayi2)
            //{
            //    Console.Write("1.sayı daha büyük.");
            //}
            //else
            //{
            //    Console.Write("2.sayı daha büyük.");
            //}

            Console.ReadKey();
        }
    }
}
