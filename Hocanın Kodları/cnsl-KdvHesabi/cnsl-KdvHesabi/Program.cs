using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_KdvHesabi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir malın fiyatı klavyeden girildiğinde %18 Kdv Tutarını ve malın kdvli fiyatını hesaplayıp gösteren Console uygulamasını yazınız.
            Console.Write("Malın Fiyatı : ");
            float MF = float.Parse(Console.ReadLine());
            //float Kdv = MF * 18 / 100;
            //float KdvliFiyat = MF + Kdv;
            //Console.WriteLine("Malın Fiyatı : {0}, Kdv : {1}, Kdvli Fiyat : {2}", MF, Kdv, KdvliFiyat);
            Console.WriteLine("Malın Fiyatı : {0}, Kdv : {1}, Kdvli Fiyat : {2}",MF, MF * 18 / 100, MF + MF * 18 / 100);
            Console.ReadKey();
        }
    }
}
