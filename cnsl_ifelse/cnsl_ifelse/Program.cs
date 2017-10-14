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
            Console.Write("1.sayiyi gir :");
            int sayi1 = int.Parse (Console.ReadLine());
            Console.Write("2.sayiyi gir :");
            int sayi2 =int.Parse (Console.ReadLine());
            if (sayi1 < sayi2) ;
            {
                Console.Write("2.sayı daha küçük ");
            }

            else
        
            {
                Console.Write("1.sayi daha büyük ");

            }
            Console.ReadKey();



        }
    }
}
