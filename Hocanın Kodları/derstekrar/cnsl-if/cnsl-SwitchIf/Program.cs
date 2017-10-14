using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_SwitchIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hangi günün hava durumunu öğrenmek istiyorsunuz?" );
            string hava = Console.ReadLine();
            //if (hava.ToLower() == "pazartesi")
            //{
            //    Console.WriteLine("Gündüz 22, Gece 3");
            //}
            //else if (hava.ToLower() == "salı")
            //{
            //    Console.WriteLine("Gündüz 18, Gece 4");

            //}
            //else if (hava.ToLower() == "çarşamba")
            //{
            //    Console.WriteLine("Gündüz 19, Gece 4");
            //}
            switch (hava)
            {
                case "pazartesi":
                    Console.WriteLine("Gündüz 22, Gece 3");
                    break;
                case "salı":
                    Console.WriteLine("Gündüz 18, Gece 4");
                    break;
                case "çarşamba":
                    Console.WriteLine("Gündüz 19, Gece 4");
                    break;
                default:
                    Console.WriteLine("Bugünün bilgisine sahip değiliz!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
