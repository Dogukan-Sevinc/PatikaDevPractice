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

            //'a' dan 'z' ye kadar tüm harfleri console a yazdır.
            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }

            Console.Write("***** Foreach *****");
            string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}