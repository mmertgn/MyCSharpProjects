using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("merhaba");
            //Console.WriteLine("isim girin");
            //string ad = Console.ReadLine();
            //Console.WriteLine("merhaba "+ad);

            Console.WriteLine("1.sayıyı girin");
            int sayi1 = int.Parse (Console.ReadLine());
            Console.WriteLine("2.sayıyı girin");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine(sayi1 + sayi2);
            //Console.WriteLine("1.sayı:{0},2.sayı:{1},toplam:{2}" ,sayi1,sayi2,    sayi1 + sayi2);





            Console.ReadKey();
        }
    }
}
