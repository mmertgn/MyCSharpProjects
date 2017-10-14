using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_IcIceDonguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int satir = 1; satir <= 10; satir++)
            //{
            //    Console.WriteLine("Dıştaki Döngü {0}", satir);
            //    for (int sutun = 1; sutun <= 2; sutun++)
            //    {
            //        Console.WriteLine("İçteki Döngü {0}-{1}", satir, sutun);
            //    }
            //}

            //for (int satir = 0; satir < 10; satir++)
            //{
            //    for (int sutun = 0; sutun < 10; sutun++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            for (int satir = 1; satir <= 15; satir++)
            {
                for (int sutun = 1; sutun <= satir; sutun++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int satir = 14; satir >= 1; satir--)
            {
                for (int sutun = satir; sutun >= 1; sutun--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
