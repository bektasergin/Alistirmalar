using System;

namespace Yuzde_degerini_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen bir yüzdelik giriniz: ");
            int yüzdelik = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0}'ın %{1}'i: ",sayi,yüzdelik);
            Console.WriteLine(sayi*yüzdelik/100);

            Console.ReadKey();






        }
    }
}
