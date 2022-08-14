using System;

namespace Alan_ve_cevre_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dikdörtgenin kısa kenarını giriniz: ");
            int kısa = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Dikdörtgenin uzun kenarını giriniz: ");
            int uzun = Convert.ToInt32(Console.ReadLine());

            int alan = (kısa * uzun);
            int cevre = ((kısa + uzun) * 2);

            Console.WriteLine("Dikdörtgenin Alanı: ");
            Console.WriteLine(alan);

            Console.WriteLine("Dikdörtgenin Çevresi: ");
            Console.WriteLine(cevre);

            Console.ReadKey();
        }
    }
}
