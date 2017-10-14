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
            //Bir malın fiyatı klavyeden girildiğinde %18 KDV tutarını ve malın KDV'li fiyatını hesaplayıp gösteren Console uygulamasını yazınız.
            Console.Write("Malın fiyatı : ");
            //float MF = float.Parse(Console.ReadLine());
            //float Kdv = MF * 18 / 100;
            //float KdvliFiyat = MF + Kdv;
            //Console.WriteLine("Malın fiyatı : {0}, Kdv : {1}, Kdvli Fiyat : {2}", MF, Kdv, KdvliFiyat);
            Console.Write("Malın fiyatı :{0}, Kdv : {1}, Kdvli Fiyat : {2}", MF * 100, MF *18 /100);
            


            Console.ReadKey();
           
            
        
           
           




        }
    }
}
