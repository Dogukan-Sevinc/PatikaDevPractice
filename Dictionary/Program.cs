using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary
        /*      Anahtar ve değer olarak verileri tutarlar. 
                Dictionaryler, system.collection.generic namespace altında kullanılırlar.
                Standart tipi;
                Dictionary<Key_Veri_Tipi, Value_Veri_Tipi> dictionary_adi = new Dictionary<Key_Veri_Tipi, Value_Veri_Tipi>();
        */

            Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();
                kullanıcılar.Add(10,"Ayşe Yılmaz"); // Keyler farklı olmalıdır mesela 10 yerine 12 olsaydı hata alırdık.
                kullanıcılar.Add(12,"Ahmet Yılmaz");    
                kullanıcılar.Add(18,"Deniz Arda");
                kullanıcılar.Add(20,"Özcan Coşar");

            // Dizinin Elemanlarına Erişim
                Console.WriteLine("***** Kullanıcı Elemanlarına Erişim ******");
                Console.WriteLine(kullanıcılar[12]);
                foreach (var item in kullanıcılar)
                    Console.WriteLine(item);
        
            // Count
                Console.WriteLine(kullanıcılar.Count);

            // Contains
                Console.WriteLine("***** Contains ******");
                Console.WriteLine(kullanıcılar.ContainsKey(12)); // True gelir
                Console.WriteLine(kullanıcılar.ContainsValue("Zikriye Ürkmez")); // False gelir

            // Remove
                Console.WriteLine("***** Remove ******");
                kullanıcılar.Remove(12);
                    foreach (var item in kullanıcılar)
                        Console.WriteLine(item.Value); // item.Value yaparsak sadece Value'ları yazdırır.

            // Keys
                Console.WriteLine("***** Keys ******");
                    foreach (var item in kullanıcılar.Keys) // Keysleri yazdırır, 10-18-20
                        Console.WriteLine(item);
            // Values
                Console.WriteLine("***** Value ******");         
                    foreach (var item in kullanıcılar.Values)  // Values'ları yazdırır. İsimler
                        Console.WriteLine(item);




        }
    }
}