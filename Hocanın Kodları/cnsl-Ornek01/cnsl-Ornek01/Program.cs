using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_Ornek01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Merhaba .NET");
            Console.WriteLine("Merhaba .NET");
            //string Ad;
            //Ad = Console.ReadLine();
            Console.Write("İsminizi Giriniz : ");
            string Ad = Console.ReadLine();
            Console.WriteLine("Hoşgeldin " + Ad);
            Console.ReadKey();
        }
    }
}
