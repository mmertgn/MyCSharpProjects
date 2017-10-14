using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnsl_forDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FOR DÖNGÜSÜ");
            Console.WriteLine("For döngüsü belirli işlemleri şart sağlandığı sürece, istenilen sayıda tekrarlamak için kullanılan bir döngüdür.");
            Console.WriteLine("for (int i = 0 (Başlangıç değeri); i < 5 (Şart); i++ (Artış değeri/Azalış değeri))");
            Console.WriteLine("{ Console.WriteLine(i); (Yapılması istenen işlemler...) }");
            Console.WriteLine("Bu for döngüsü 0'dan başlayıp 4'e kadar olan sayıları alt alta yazar.");
            Console.WriteLine("Kodun çalışan hali aşağıdaki gibidir:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Başka bir örnekle devam edelim...");
            Console.WriteLine("1-20 arasındaki çift sayıları ekrana yazdıran programın kodları şöyledir:");
            Console.WriteLine("for (int k = 1; k <= 20 (20 dahil); k++)");
            Console.WriteLine("{if (k % 2 == 0) { Console.WriteLine(k.ToString()); }");
            Console.WriteLine("Kodun çalışan hali ise aşağıdaki gibidir.");
            for (int k = 1; k <= 20; k++)
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine(k.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
