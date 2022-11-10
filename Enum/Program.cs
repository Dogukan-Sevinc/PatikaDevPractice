using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);    // Pazar'ı direk yazdırıyor
            Console.WriteLine((int)Gunler.Cumartesi); // Numeric olarak erişiyoruz, 5 sayısını veriyor.

            int sıcaklık = 29;

            if(sıcaklık<=(int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya çıkmak için havanın ısınmasını bekleyeim.");
            else if(sıcaklık>=(int)HavaDurumu.Sıcak)
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            else if(sıcaklık>=(int)HavaDurumu.Normal && sıcaklık<(int)HavaDurumu.CokSıcak)
                Console.WriteLine("Hadi dışarıya çıkalım!");
            


        }

        enum Gunler
        {
            Pazartesi,
            Salı,
            Çarşamba,
            Perşembe,
            Cuma = 23, // Burada Cuma'yı 23 sayısını tutsun diye atıyoruz. Cumartesi günü otomatik 24 olur. 1 artar.
            Cumartesi,
            Pazar
        }

        enum HavaDurumu
        {
            Soguk = 5,
            Normal = 20,
            Sıcak = 25,
            CokSıcak = 30
        }
    }
}