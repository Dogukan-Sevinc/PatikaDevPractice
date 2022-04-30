using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int [] sayiDizisi = {23,12,4,86,72,3,11,17};
           
            Console.WriteLine("***** Sırasız Dizi *****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("***** Sıralı Dizi *****");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Clear
            Console.WriteLine("***** Array Cleaner *****");
            // sayiDizisi elemanlarını kullanarak 2.index ten itibaren 2 tane elamanı 0'lar.
            Array.Clear(sayiDizisi,2,2);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Reverse ==> Diziyi ters çevirme
            Console.WriteLine("***** Array Reverse *****");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //IndexOf ==> İlgili sayının index'ini verme
            Console.WriteLine("***** Array IndexOf *****");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //Resize ==> Sayı Değerini Set Etme
            Console.WriteLine("***** Array Resize *****");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8]=99;

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


        



            
        }
    }
}