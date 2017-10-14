using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_ForDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Merhaba");
            //}

            //1-10 arası sayıları gösteren döngü.
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //1-10 arası tek sayıları gösteren döngü.
            //for (int i = 1; i < 10; i=i+2)
            //{
            //    Console.WriteLine(i);
            //}

            //0-10 arası çift sayıları gösteren döngü.
            //for (int i = 0; i <= 10; i+=2)
            //{
            //    Console.WriteLine(i);
            //}
            //1-10 arası çift sayıları gösteren döngü.
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //10-1 sayıları tersten görüntüleyen döngü.
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
