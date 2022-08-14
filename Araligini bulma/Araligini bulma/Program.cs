using System;

namespace Araligini_bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi>=0 && sayi<=100)
            {
                Console.WriteLine("{0} 0 ve 100 arasındadır. ",sayi);
            }
            else
            {
                Console.WriteLine("{0} 0 ve 100 arasında değildir. ",sayi);
            }

            Console.ReadKey();
        }


    }
}
