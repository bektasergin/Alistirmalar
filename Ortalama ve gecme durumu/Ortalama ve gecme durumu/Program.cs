using System;

namespace Ortalama_ve_gecme_durumu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen birinci yazılıyı giriniz: ");
            int yazili = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen ikinci yazılıyı giriniz: ");
            int yazili1 = Convert.ToInt32(Console.ReadLine());

            int ortalama = (yazili + yazili1) / 2;

            Console.Write("Öğrencinin ortalaması: ");
            Console.WriteLine(ortalama);

            if (ortalama>=50)
            {
                Console.Write("Öğrenci geçmiştir. ");
            }
            else
            {
                Console.Write("Öğrenci geçememiştir. ");
            }

            Console.ReadKey();




        }
    }
}
