using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_YasHesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Doğum Yılı: ");
            //int DYili = int.Parse(Console.ReadLine());

            ////Console.WriteLine("Yaşınız : {0}", 2017 - DYili);
            //Console.WriteLine("Yaşınız : {0}", DateTime.Now.Year - DYili);

            Console.Write("Doğum Tarihinizi Giriniz (01.01.2000) : ");
            DateTime time = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Yaşınız :" + (DateTime.Now.Year - time.Year));
            Console.ReadKey();
        }
    }
}
