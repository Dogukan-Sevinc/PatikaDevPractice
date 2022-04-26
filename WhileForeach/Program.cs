using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayi giriniz!");
            int toplam = 0;
            int sayac = 1;
            int sayi = Convert.ToInt32(Console.ReadLine());
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine("1'den sayiya kadar olan sayilarin ortalaması: {0}", (toplam / sayi));
        }
    }
}