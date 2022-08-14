using System;

namespace switch_case
{
    public class Program 
    {
        enum Islemler 
        {
          Toplama,
          Cikarma,
          Carpma,
          Bolme
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen bir sayı daha giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplama için 0'a");
            Console.WriteLine("Çıkarma için 1'e");
            Console.WriteLine("Çarpma için 2'ye");
            Console.Write("Bölme için 3'e basınız: ");
            Islemler secim = (Islemler)Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case Islemler.Toplama:
                    Console.WriteLine($"{sayi}+{sayi1}={sayi+sayi1}");
                    break;
                case Islemler.Cikarma:
                    Console.WriteLine($"{sayi}-{sayi1}={sayi - sayi1}");
                    break;
                case Islemler.Carpma:
                    Console.WriteLine($"{sayi}*{sayi1}={sayi * sayi1}");
                    break;
                case Islemler.Bolme:
                    Console.WriteLine($"{sayi}/{sayi1}={sayi / sayi1}");
                    break;
                default:
                    Console.WriteLine("\aGeçersiz İşlem! ");
                    break;
            }





            Console.ReadKey();
        }
    }
}
