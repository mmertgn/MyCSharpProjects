using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_SinifGecme
{
    class Program
    {
        static void Main(string[] args)
        {
            //50-59 -> CC
            //60-69 -> CB
            //70-79 -> BB
            //80-89 -> BA
            //90-100 -> AA
            Console.Write("1.Notu Giriniz : ");
            int Not1 = int.Parse(Console.ReadLine());
            Console.Write("2.Notu Giriniz : ");
            int Not2 = int.Parse(Console.ReadLine());
            if (Not1 >= 0 && Not1 <= 100 && Not2 >= 0 && Not2 <= 100)
            {
                int Ort = (Not1 + Not2) / 2;
                if (Ort < 50)
                    Console.WriteLine("Sınıfta kaldınız.");
                else if (Ort >= 50 && Ort < 60)
                    Console.WriteLine("CC ile geçtiniz.");
                else if (Ort >= 60 && Ort < 70)
                    Console.WriteLine("CB ile geçtiniz.");
                else if (Ort >= 70 && Ort < 80)
                    Console.WriteLine("BB ile geçtiniz.");
                else if (Ort >= 80 && Ort < 90)
                    Console.WriteLine("BA ile geçtiniz.");
                else if (Ort >= 90 && Ort <= 100)
                    Console.WriteLine("AA ile geçtiniz.");
            }
            else { Console.WriteLine("Notlar 0-100 aralığında girilmelidir!"); }
            //and -> && iki şart da gerçekleşmeli (true && true)
            //or  -> || şartlardan birinin bile gerçekleşmesi yeterli (true || true, true || false, false || true)

            //if (Ort < 50)
            //    Console.WriteLine("Sınıfta kaldınız.");
            //else if (Ort < 60)
            //    Console.WriteLine("CC ile geçtiniz.");
            //else if (Ort < 70)
            //    Console.WriteLine("CB ile geçtiniz.");
            //else if (Ort < 80)
            //    Console.WriteLine("BB ile geçtiniz.");
            //else if (Ort < 90)
            //    Console.WriteLine("BA ile geçtiniz.");
            //else
            //    Console.WriteLine("AA ile geçtiniz.");

            Console.ReadKey();
        }
    }
}
