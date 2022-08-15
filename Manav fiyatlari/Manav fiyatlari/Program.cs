using System;

namespace Manav_fiyatlari
{
    class Program
    {
        enum Meyveler 
        {
          Mandalina,
          Karpuz,
          Kavun,
          Kiraz,
          Cilek,
          Portakal,
          Avakado
        }
        static void Main(string[] args)
        {
            Console.WriteLine("  - Mandalina için 0'a ");
            Console.WriteLine("  - Karpuz için 1'e ");
            Console.WriteLine("  - Kavun için 2'ye ");
            Console.WriteLine("  - Kiraz için 3'e ");
            Console.WriteLine("  - Çilek için 4'e ");
            Console.WriteLine("  - Portakal için 5'e ");
            Console.Write("  - Avakado için 6'ya basın: ");

            Meyveler sayi = (Meyveler)Convert.ToInt32(Console.ReadLine());

            double Mandalina = 2.90;
            double Karpuz = 3.25;
            double Kavun = 2.25;
            double Kiraz = 3.21;
            double Cilek = 3.25;
            double Portakal = 5;
            double Avakado = 6.25;

            Console.WriteLine(" ");
            
            Console.Write("  Kaç kilo alacaksınız ? = ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            switch (sayi)
            {
                case Meyveler.Mandalina:
                    Console.Write("  Fiyatı: ");
                    Console.Write(sayi1*Mandalina);
                    break;
                case Meyveler.Karpuz:
                    Console.Write("  Fiyatı: ");
                    Console.Write(sayi1 * Karpuz);
                    break;
                case Meyveler.Kavun:
                    Console.Write("  Fiyatı: ");
                    Console.Write(sayi1 * Kavun);
                    break;
                case Meyveler.Kiraz:
                    Console.Write("  Fiyatı: ");
                    Console.Write(sayi1 * Kiraz);
                    break;
                case Meyveler.Cilek:
                    Console.Write("  Fiyatı: ");
                    Console.Write(sayi1 * Cilek);
                    break;
                case Meyveler.Portakal:
                    Console.Write("  Fiyatı: ");
                    Console.Write(sayi1 * Portakal);
                    break;
                case Meyveler.Avakado:
                    Console.Write("  Fiyatı: ");
                    Console.Write(sayi1 * Avakado);
                    break;
                default:
                    Console.Write("\aGeçersiz ürün! ");
                    break;
            }




            Console.ReadKey();
        }
    }
}
