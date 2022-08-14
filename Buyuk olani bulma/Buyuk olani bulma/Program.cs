using System;

namespace Buyuk_olani_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen bir sayı daha giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            if (sayi>sayi1)
            {
                Console.WriteLine("{0} {1}'den daha büyük. ",sayi,sayi1);
            }
            else if (sayi==sayi1)
            {
                Console.WriteLine("{0} ve {1} eşitler. ",sayi,sayi1);
            }
            else
            {
                Console.WriteLine("{1} {0}'dan daha büyük. ",sayi,sayi1);
            }

            Console.ReadKey();
        }
    }
}
