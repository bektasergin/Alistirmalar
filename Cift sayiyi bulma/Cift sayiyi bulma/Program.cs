using System;

namespace Cift_sayiyi_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi%2==0)
            {
                Console.WriteLine("{0} bir çift sayıdır. ",sayi);
            }
            else
            {
                Console.WriteLine("{0} bir çift sayı değildir. ", sayi);
            }

            Console.ReadKey();
        }
    }
}
