using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. Notu Giriniz : ");
            int Not1 = int.Parse(Console.ReadLine());
            Console.Write("2. Notu Giriniz : ");
            int Not2 = int.Parse(Console.ReadLine());


            int Ort = (Not1 + Not2) / 2;
        
            if (Ort < 50)
                Console.WriteLine("Sınıfta kaldınız. ");
            else if (Ort >= 50 && Ort < 60) ;
                 Console.WriteLine("CC ile geçtiniz. ");
            else if (Ort >= 60 && Ort < 70) ;
                 Console.WriteLine("CB ile geçtiniz. ");
            else if (Ort >= 70 && Ort < 80) ;
                 Console.WriteLine("BB ile geçtiniz. ");
            else if (Ort >= 80 && Ort < 90) ;
                 Console.WriteLine("BA ile geçtiniz. ");
            else if (Ort >= 90 && Ort <= 100)
                 Console.WriteLine("AA ile geçtiniz. ");





            Console.ReadKey();





            //if (Ort < 50)
            //    Console.WriteLine("Sınıfa Kaldınız. ");
            //else if (Ort < 60)
            //    Console.WriteLine("CC ile geçtiniz. ");
            //else if (Ort < 70)
            //    Console.WriteLine("CB ile geçtiniz. ");
            //else if (Ort < 80)
            //    Console.WriteLine("BB ile geçtiniz. ");
            //else if (Ort < 90)
            //    Console.WriteLine("BA ile geçtiniz. ");
            //else
            //    Console.WriteLine("AA ile geçtiniz. ");





        }
    }
}
