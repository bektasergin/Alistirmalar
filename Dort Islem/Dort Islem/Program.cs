using System;

namespace Dort_Islem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen bir sayı daha giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0} ve {1}'in toplamı: ",sayi,sayi1);
            Console.WriteLine(sayi+sayi1);

            Console.Write("{0} ve {1}'in farkı: ", sayi, sayi1);
            Console.WriteLine(sayi - sayi1);

            Console.Write("{0} ve {1}'in çarpımı: ", sayi, sayi1);
            Console.WriteLine(sayi * sayi1);

            Console.Write("{0}'ın {1}'e bölümü: ", sayi, sayi1);
            Console.WriteLine(sayi / sayi1);

            Console.ReadKey();
        }
    }
}
