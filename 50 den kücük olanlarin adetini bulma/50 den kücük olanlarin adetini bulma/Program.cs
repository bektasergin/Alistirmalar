using System;

namespace _50_den_kücük_olanlarin_adetini_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, adet = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i+".sayıyı giriniz: ");
                sayi = Int32.Parse(Console.ReadLine());
                if (sayi<50)
                {
                    adet++;
                }
            }

            Console.WriteLine("50 den küçük girilen sayı adeti: "+adet);
            Console.ReadKey();

        }

    }
}
